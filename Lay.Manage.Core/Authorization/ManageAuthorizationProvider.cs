﻿using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace Lay.Manage.Authorization
{
    public class ManageAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //Common permissions
            var pages = context.GetPermissionOrNull(AppPermissions.Pages);
            if (pages == null)
            {
                pages = context.CreatePermission(AppPermissions.Pages, L("Pages"));
            }

            var users = pages.CreateChildPermission(AppPermissions.Pages_Users, L("Users"));

            //Host permissions
            var tenants = pages.CreateChildPermission(AppPermissions.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

            //Products
            var products = context.GetPermissionOrNull(AppPermissions.Products);
            if (products == null)
            {
                products = context.CreatePermission(AppPermissions.Products, L("Products"));
            }
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, ManageConsts.LocalizationSourceName);
        }
    }
}
