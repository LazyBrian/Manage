using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Lay.Manage.Product.Dto;

namespace Lay.Manage.Products.Dto
{
    [AutoMapFrom(typeof(Product))]
    public class ProductDto:EntityDto<int>
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Pic { get; set; }
        public string Asin { get; set; }
        public SiteType Type { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public CashbackDto Cashback { get; set; }
        public Remark Remark { get; set; }
        public string ColorType { get; set; }
        public string Email { get; set; }
        public string MerchantID { get; set; }
        

    }
}
