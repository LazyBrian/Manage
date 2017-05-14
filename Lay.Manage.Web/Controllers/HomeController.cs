using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Lay.Manage.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ManageControllerBase
    {
        public ActionResult Index()
        {
            var permissions = PermissionManager.GetAllPermissions();
            var role = PermissionManager.GetPermission("Products");
            return View(role);
          
        }
	}
}