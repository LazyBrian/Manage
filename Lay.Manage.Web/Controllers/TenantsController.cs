using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Lay.Manage.Authorization;
using Lay.Manage.MultiTenancy;

namespace Lay.Manage.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Tenants)]
    public class TenantsController : ManageControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}