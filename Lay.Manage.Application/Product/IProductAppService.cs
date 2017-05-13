using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Lay.Manage.Products.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lay.Manage.Products
{
   public interface IProductAppService: IApplicationService
    {
        Task<ListResultDto<ProductDto>> GetList();

        int AddPro(CreateProductInput input);

        Task DeleteEdition(DeleteEditionInput input);

        Task EditProduct(ProductDto input);

        Task<ProductDto> GetProductById(int id);

        Task<ListResultDto<Categorylist>> GetCategoryList();

     

    }
}
