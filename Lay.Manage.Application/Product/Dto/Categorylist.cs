using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Lay.Manage.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lay.Manage.Products.Dto
{
    [AutoMapFrom(typeof(Category))]
    public class Categorylist: EntityDto
    {
        public string Text { get; set; }
    }
}
