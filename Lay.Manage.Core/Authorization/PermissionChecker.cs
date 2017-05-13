using Abp.Authorization;
using Lay.Manage.Authorization.Roles;
using Lay.Manage.MultiTenancy;
using Lay.Manage.Users;

namespace Lay.Manage.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
