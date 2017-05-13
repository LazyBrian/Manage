
// 项目展示地址:"http://www.ddxc.org/"
 // 如果你有什么好的建议或者觉得可以加什么功能，请加QQ群：104390185大家交流沟通
// 项目展示地址:"http://www.yoyocms.com/"
//博客地址：http://www.cnblogs.com/wer-ltm/
//代码生成器帮助文档：http://www.cnblogs.com/wer-ltm/p/5777190.html
//<Author-作者>角落的白板笔</Author-作者>
// Copyright © YoYoCms@中国.2017-05-11T21:33:04. All Rights Reserved.
//<生成时间>2017-05-11T21:33:04</生成时间>
using System;
using System.ComponentModel;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Lay.Manage.Products;

namespace Lay.Manage.Products.Dtos
{
	/// <summary>
    /// 产品列表Dto
    /// </summary>
    [AutoMapFrom(typeof(Product))]
    public class ProductListDto : EntityDto<int>
    {
        /// <summary>
        /// 是否激活
        /// </summary>
        [DisplayName("是否激活")]
        public      bool IsActive { get; set; }
        /// <summary>
        /// 产品类型
        /// </summary>
        [DisplayName("产品类型")]
        public      SiteType Type { get; set; }
		/// <summary>
        /// 产品类型(枚举描述)
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// 产品分类
        /// </summary>
        [DisplayName("产品分类")]
        public      int CategoryId { get; set; }
        public      int CashbackId { get; set; }
        public      int RemarkId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public      DateTime CreationTime { get; set; }
    }
}
