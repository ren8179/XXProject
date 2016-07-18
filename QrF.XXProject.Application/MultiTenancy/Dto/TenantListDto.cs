using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace QrF.XXProject.MultiTenancy.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantListDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}