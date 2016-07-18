using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using QrF.XXProject.Authorization;
using QrF.XXProject.MultiTenancy;

namespace QrF.XXProject.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : XXProjectControllerBase
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