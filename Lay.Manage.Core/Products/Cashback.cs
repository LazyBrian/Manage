using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lay.Manage.Products
{
  public  class Cashback : FullAuditedEntity<int>
    {
        public Cashback()
        {
            IsComment = false;
        }
        public decimal SalesPrice { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public decimal Discount { get; set; }

        public decimal Price { get; set; }

        public decimal Pay { get; set; }

        public bool IsComment { get; set; }
    }
}
