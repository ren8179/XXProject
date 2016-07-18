using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using QrF.XXProject.MultiTenancy;

namespace QrF.XXProject.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}