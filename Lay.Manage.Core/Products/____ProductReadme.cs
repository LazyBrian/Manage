
// 项目展示地址:"http://www.ddxc.org/"
 // 如果你有什么好的建议或者觉得可以加什么功能，请加QQ群：104390185大家交流沟通
// 项目展示地址:"http://www.yoyocms.com/"
//博客地址：http://www.cnblogs.com/wer-ltm/
//代码生成器帮助文档：http://www.cnblogs.com/wer-ltm/p/5777190.html
// <Author-作者>角落的白板笔</Author-作者>
// Copyright © YoYoCms@中国.2017-05-11T21:33:08. All Rights Reserved.
//<生成时间>2017-05-11T21:33:08</生成时间>
namespace Lay.Manage.Products
{
	
	

		//TODO:多页面后端的导航栏目设计

	/*
	//无次级导航属性
	   var product=new MenuItemDefinition(
                ProductAppPermissions.Product,
                L("Product"),
				url:"Mpa/ProductManage",
				icon:"icon-grid",
				 requiredPermissionName: ProductAppPermissions.Product
				);

*/
				//有下级菜单
            /*

			   var product=new MenuItemDefinition(
                ProductAppPermissions.Product,
                L("Product"),			
				icon:"icon-grid"				
				);

				product.AddItem(
			new MenuItemDefinition(
			ProductAppPermissions.Product,
			L("Product"),
			"icon-star",
			url:"Mpa/ProductManage",
			requiredPermissionName: ProductAppPermissions.Product));
	

			
			*/

	
			
	
	
	
	//配置权限模块初始化
 //TODO:★需要到请将以下内容剪切到ManageApplicationModule
 //   Configuration.Authorization.Providers.Add<ProductAppAuthorizationProvider>();


 

//TODO:★请将以下内容剪切到CORE类库的Localization/Source/Managezh-cn.xml
//第一次加载建议复制他
// <text name="MustBe_Required" value="不能为空" />


/*
    <!-- 产品管理 -->
	    <text name="Product" value="产品" />
	    <text name="ProductHeaderInfo" value="产品管理列表" />
		    <text name="CreateProduct" value="新增产品" />
    <text name="EditProduct" value="编辑产品" />
    <text name="DeleteProduct" value="删除产品" />

	  
		

		    <text name="ProductDeleteWarningMessage" value="产品名称: {0} 将被删除,是否确定删除它。" />
<!--//用于表格展示的数据信息的标题-->
					<text name="IsActive" value="是否激活" />
				 	<text name="Name" value="产品名称" />
				 	<text name="Url" value="产品链接" />
				 	<text name="Pic" value="图片" />
				 	<text name="Asin" value="ASIN" />
				 	<text name="Type" value="产品类型" />
				 	<text name="Description" value="说明" />
				 	<text name="CategoryId" value="产品分类" />
				 	<text name="ColorType" value="变体" />
				 	<text name="Email" value="邮箱" />
				 	<text name="MerchantID" value="MerchantID" />
				 	<text name="Cashback" value="Cashback" />
				 	<text name="CashbackId" value="CashbackId" />
				 	<text name="Remark" value="备注" />
				 	<text name="RemarkId" value="RemarkId" />
				 	<text name="LastModificationTime" value="最后编辑时间" />
				 	<text name="CreationTime" value="创建时间" />
				 
*/


//TODO:★请将以下内容剪切到CORE类库的Localization/Source/Manage.xml
/*
    <!-- 产品english管理 -->
		    <text name="	ProductHeaderInfo" value="产品List" />
			<!--//用于表格展示的数据信息的标题-->
					<text name="IsActive" value="是否激活" />
				 	<text name="Name" value="产品名称" />
				 	<text name="Url" value="产品链接" />
				 	<text name="Pic" value="图片" />
				 	<text name="Asin" value="ASIN" />
				 	<text name="Type" value="产品类型" />
				 	<text name="Description" value="说明" />
				 	<text name="CategoryId" value="产品分类" />
				 	<text name="ColorType" value="变体" />
				 	<text name="Email" value="邮箱" />
				 	<text name="MerchantID" value="MerchantID" />
				 	<text name="Cashback" value="Cashback" />
				 	<text name="CashbackId" value="CashbackId" />
				 	<text name="Remark" value="备注" />
				 	<text name="RemarkId" value="RemarkId" />
				 	<text name="LastModificationTime" value="最后编辑时间" />
				 	<text name="CreationTime" value="创建时间" />
				 
    <text name="Product" value="ManagementProduct" />
    <text name="CreateProduct" value="CreateProduct" />
    <text name="EditProduct" value="EditProduct" />
    <text name="DeleteProduct" value="DeleteProduct" />
*/




}