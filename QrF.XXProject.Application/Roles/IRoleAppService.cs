using System.Threading.Tasks;
using Abp.Application.Services;
using QrF.XXProject.Roles.Dto;

namespace QrF.XXProject.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
