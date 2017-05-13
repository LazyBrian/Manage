using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Lay.Manage.Products.Dto;
using Abp.Domain.Repositories;
using Lay.Manage.AmazonData;
using Abp.AutoMapper;

namespace Lay.Manage.Products
{
    public class ProductAppService : ManageAppServiceBase, IProductAppService
    {
        private readonly IRepository<Product, int> _productRepository;
        private readonly IRepository<Cashback> _cashbackRepository;
        private readonly IRepository<Category> _categoryRepository;
        //private readonly IAmazonProductService _amazonProductService;
        public ProductAppService(IRepository<Product, int> productRepository, IRepository<Cashback> cashbackRepository,IRepository<Category> categoryRespoitory)
        {
            _productRepository = productRepository;
            _cashbackRepository = cashbackRepository;
            _categoryRepository = categoryRespoitory;
            //_amazonProductService = amazonProductService;
        }

        public int AddPro(CreateProductInput input)
        {
            AmazonProductService service = new AmazonProductService();
            var product = service.GetProduct(input.Url);
            product.Cashback = new Cashback() { SalesPrice = 18 };

            var id = _productRepository.InsertOrUpdateAndGetId(product);
            return id;
        }

        public async Task<ListResultDto<ProductDto>> GetList()
        {
            var products = _productRepository.GetAllIncluding(c => c.Cashback);
            
            return new ListResultDto<ProductDto>(
                products.MapTo<List<ProductDto>>()
                );
        }
        public async Task DeleteEdition(DeleteEditionInput input)
        {
            await _productRepository.DeleteAsync(input.Id);
        }

        public async Task EditProduct(ProductDto input)
        {
            var product = input.MapTo<Product>();
            await _productRepository.UpdateAsync(product);
            //await _cashbackRepository.UpdateAsync(product.Cashback);
        }

        public async Task<ProductDto> GetProductById(int id)
        {
            var product = await _productRepository.SingleAsync(c => c.Id == id);

            return product.MapTo<ProductDto>();

        }

        public async Task<ListResultDto<Categorylist>> GetCategoryList()
        {
            var category = await _categoryRepository.GetAllListAsync();
            return new ListResultDto<Categorylist>(category.MapTo<List<Categorylist>>());
        }
    }
}
