using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using QrF.XXProject.MultiTenancy.Dto;

namespace QrF.XXProject.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
