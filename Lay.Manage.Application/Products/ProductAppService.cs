


// 项目展示地址:"http://www.ddxc.org/"
// 如果你有什么好的建议或者觉得可以加什么功能，请加QQ群：104390185大家交流沟通
// 项目展示地址:"http://www.yoyocms.com/"
//博客地址：http://www.cnblogs.com/wer-ltm/
//代码生成器帮助文档：http://www.cnblogs.com/wer-ltm/p/5777190.html
// <Author-作者>角落的白板笔</Author-作者>
// Copyright © YoYoCms@中国.2017-05-11T21:33:07. All Rights Reserved.
//<生成时间>2017-05-11T21:33:07</生成时间>
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;
using System.Threading.Tasks;
using Abp;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Configuration;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using Lay.Manage.Products.Authorization;
using Lay.Manage.Products.Dtos;

namespace Lay.Manage.Products
{
    /// <summary>
    /// 产品服务实现
    /// </summary>
   // [AbpAuthorize(ProductAppPermissions.Product)]
    public class ProductAppService : ManageAppServiceBase, IProductAppService
    {
        private readonly IRepository<Product, int> _productRepository;
        private readonly IRepository<Cashback, int> _cashbackRepository;
        private readonly IRepository<Remark, int> _remarkRepository;
        //     private readonly IProductListExcelExporter _productListExcelExporter;


        private readonly ProductManage _productManage;
        /// <summary>
        /// 构造方法
        /// </summary>
        public ProductAppService(IRepository<Product, int> productRepository, ProductManage productManage, IRepository<Cashback, int> cashbackRepository, IRepository<Remark, int> remarkRepository
  //,            IProductListExcelExporter productListExcelExporter  
  )
        {
            _productRepository = productRepository;
            _productManage = productManage;
            _cashbackRepository = cashbackRepository;
            _remarkRepository = remarkRepository;
            //_productListExcelExporter = productListExcelExporter;  
        }

        #region 产品管理

        /// <summary>
        /// 根据查询条件获取产品分页列表
        /// </summary>
        public async Task<PagedResultDto<ProductListDto>> GetPagedProductsAsync(GetProductInput input)
        {

            var query = _productRepository.GetAll();
            //TODO:根据传入的参数添加过滤条件

            var productCount = await query.CountAsync();

            var products = await query
            .OrderBy(input.Sorting)
            .PageBy(input)
            .ToListAsync();

            var productListDtos = products.MapTo<List<ProductListDto>>();
            return new PagedResultDto<ProductListDto>(
            productCount,
            productListDtos
            );
        }

        /// <summary>
        /// 通过Id获取产品信息进行编辑或修改 
        /// </summary>
        public async Task<GetProductForEditOutput> GetProductForEditAsync(NullableIdDto<int> input)
        {
            var output = new GetProductForEditOutput();

            ProductEditDto productEditDto;

            if (input.Id.HasValue)
            {
                var entity = await _productRepository.GetAsync(input.Id.Value);
                productEditDto = entity.MapTo<ProductEditDto>();
            }
            else
            {
                productEditDto = new ProductEditDto();
            }

            output.Product = productEditDto;
            return output;
        }


        /// <summary>
        /// 通过指定id获取产品ListDto信息
        /// </summary>
        public async Task<ProductListDto> GetProductByIdAsync(EntityDto<int> input)
        {
            var entity = await _productRepository.GetAsync(input.Id);

            return entity.MapTo<ProductListDto>();
        }

        /// <summary>
        /// 新增或更改产品
        /// </summary>
        public async Task CreateOrUpdateProductAsync(CreateOrUpdateProductInput input)
        {
            if (input.ProductEditDto.Id.HasValue)
            {
                await UpdateProductAsync(input.ProductEditDto);
            }
            else
            {
                await CreateProductAsync(input.ProductEditDto);
            }
        }

        /// <summary>
        /// 新增产品
        /// </summary>
        //[AbpAuthorize(ProductAppPermissions.Product_CreateProduct)]
        public virtual async Task<ProductEditDto> CreateProductAsync(ProductEditDto input)
        {
            //TODO:新增前的逻辑判断，是否允许新增

            var entity = input.MapTo<Product>();

            entity = await _productRepository.InsertAsync(entity);
            return entity.MapTo<ProductEditDto>();
        }

        /// <summary>
        /// 编辑产品
        /// </summary>
        //[AbpAuthorize(ProductAppPermissions.Product_EditProduct)]
        public virtual async Task UpdateProductAsync(ProductEditDto input)
        {
            //TODO:更新前的逻辑判断，是否允许更新

            var entity = await _productRepository.GetAsync(input.Id.Value);
            
            input.MapTo(entity);
                      
            await _productRepository.UpdateAsync(entity);
            //await _cashbackRepository.UpdateAsync(entity.Cashback);
            //await _remarkRepository.UpdateAsync(entity.Remark);
        }

        /// <summary>
        /// 删除产品
        /// </summary>
        //[AbpAuthorize(ProductAppPermissions.Product_DeleteProduct)]
        public async Task DeleteProductAsync(EntityDto<int> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _productRepository.DeleteAsync(input.Id);
        }

        /// <summary>
        /// 批量删除产品
        /// </summary>
        //[AbpAuthorize(ProductAppPermissions.Product_DeleteProduct)]
        public async Task BatchDeleteProductAsync(List<int> input)
        {
            //TODO:批量删除前的逻辑判断，是否允许删除
            await _productRepository.DeleteAsync(s => input.Contains(s.Id));
        }

        #endregion


        #region 产品的Excel导出功能


        //public async Task<FileDto> GetProductToExcel()
        //{
        //    var entities = await _productRepository.GetAll().ToListAsync();

        //    var dtos = entities.MapTo<List<ProductListDto>>();

        //    var fileDto = _productListExcelExporter.ExportProductToFile(dtos);



        //    return fileDto;
        //}


        #endregion










    }
}
