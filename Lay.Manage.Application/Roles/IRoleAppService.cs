using System.Threading.Tasks;
using Abp.Application.Services;
using Lay.Manage.Roles.Dto;

namespace Lay.Manage.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
