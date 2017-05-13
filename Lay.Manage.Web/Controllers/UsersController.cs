using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Lay.Manage.Authorization;
using Lay.Manage.Users;

namespace Lay.Manage.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Users)]
    public class UsersController : ManageControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _userAppService.GetUsers();
            return View(output);
        }
    }
}