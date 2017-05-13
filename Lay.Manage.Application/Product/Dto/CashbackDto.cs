using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using Lay.Manage.Products;

namespace Lay.Manage.Product.Dto
{
    [AutoMapFrom(typeof(Cashback))]
    public class CashbackDto : EntityDto
    {
        public decimal SalesPrice { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public decimal Discount { get; set; }

        public decimal Price { get; set; }

        public decimal Pay { get; set; }
        public bool IsComment { get; set; }

    }
}
