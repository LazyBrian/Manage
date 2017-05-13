
// 项目展示地址:"http://www.ddxc.org/"
 // 如果你有什么好的建议或者觉得可以加什么功能，请加QQ群：104390185大家交流沟通
// 项目展示地址:"http://www.yoyocms.com/"
//博客地址：http://www.cnblogs.com/wer-ltm/
//代码生成器帮助文档：http://www.cnblogs.com/wer-ltm/p/5777190.html
// <Author-作者>角落的白板笔</Author-作者>
// Copyright © YoYoCms@中国.2017-05-11T21:33:04. All Rights Reserved.
//<生成时间>2017-05-11T21:33:04</生成时间>
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using Abp.Runtime.Validation;
using Abp.Extensions;
using Lay.Manage.Products;

namespace Lay.Manage.Products.Dtos
{
    /// <summary>
    /// 产品编辑用Dto
    /// </summary>
    [AutoMap(typeof(Product))]
    public class ProductEditDto 
    {

	/// <summary>
    ///   主键Id
    /// </summary>
    [DisplayName("主键Id")]
	public int? Id{get;set;}

        /// <summary>
        /// 是否激活
        /// </summary>
        [DisplayName("是否激活")]
        public   bool  IsActive { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [DisplayName("产品名称")]
        public   string  Name { get; set; }

        /// <summary>
        /// 产品链接
        /// </summary>
        [DisplayName("产品链接")]
        public   string  Url { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [DisplayName("图片")]
        public   string  Pic { get; set; }

        /// <summary>
        /// ASIN
        /// </summary>
        [DisplayName("ASIN")]
        public   string  Asin { get; set; }

        /// <summary>
        /// 产品类型
        /// </summary>
        [DisplayName("产品类型")]
        public   SiteType  Type { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        [DisplayName("说明")]
        public   string  Description { get; set; }

        /// <summary>
        /// 产品分类
        /// </summary>
        [DisplayName("产品分类")]
        public   int  CategoryId { get; set; }

        /// <summary>
        /// 变体
        /// </summary>
        [DisplayName("变体")]
        public   string  ColorType { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [DisplayName("邮箱")]
        public   string  Email { get; set; }

        public   string  MerchantID { get; set; }

        public   Cashback  Cashback { get; set; }

        public   int  CashbackId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName("备注")]
        public   Remark  Remark { get; set; }

        public   int  RemarkId { get; set; }

    }
}
