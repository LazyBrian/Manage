using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lay.Manage.Products
{
    public class Product : FullAuditedEntity<int>, IPassivable
    {
        public Product()
        {
            IsActive = false;
            Cashback = new Cashback();
            Remark = new Remark();

        }

        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Pic { get; set; }
        public string Asin { get; set; }
        public SiteType Type { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string ColorType { get; set; }
        public string Email { get; set; }
        public string MerchantID { get; set; }

       
        public virtual Cashback Cashback { get; set; }
        public int CashbackId { get; set; }
        
        public virtual Remark Remark { get; set; }
        public int RemarkId { get; set; }

    }
}
