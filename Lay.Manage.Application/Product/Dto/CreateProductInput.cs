using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Lay.Manage.Products.Dto
{
    [AutoMap(typeof(Product))]
    public class CreateProductInput
    {
        [Required]
        public string Url { get; set; }

        public SiteType Type { get; set; }
    }
}
