namespace Lay.Manage.Authorization
{
    public static class AppPermissions
    {
        public const string Pages = "Pages";

        public const string Pages_Tenants = "Pages.Tenants";

        public const string Pages_Users = "Pages.Users";

        public const string Products = "Products";

        /// <summary>
        /// 产品管理权限
        /// </summary>
        public const string Product = "Pages.Product";



        /// <summary>
        /// 产品创建权限
        /// </summary>
        public const string Product_CreateProduct = "Pages.Product.CreateProduct";
        /// <summary>
        /// 产品修改权限
        /// </summary>
        public const string Product_EditProduct = "Pages.Product.EditProduct";
        /// <summary>
        /// 产品删除权限
        /// </summary>
        public const string Product_DeleteProduct = "Pages.Product.DeleteProduct";

        public static string Pages_Administration = "AppPermissions.Admins";
    }
}