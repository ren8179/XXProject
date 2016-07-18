using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using QrF.XXProject.Authorization.Roles;
using QrF.XXProject.Editions;
using QrF.XXProject.Users;

namespace QrF.XXProject.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore
            ) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore
            )
        {
        }
    }
}