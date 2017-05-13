using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lay.Manage.Products
{
   public class Remark: Entity
    {
      public string ColorTypeDesc { get; set; }
      public string TransportDesc{ get; set; }

        public string SellerDesc { get; set; }
        public string CouponDesc { get; set; }
    }
}
