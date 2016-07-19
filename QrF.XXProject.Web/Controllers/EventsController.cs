using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using QrF.XXProject.Authorization;
using QrF.XXProject.Users;

namespace QrF.XXProject.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class EventsController : XXProjectControllerBase
    {
        private readonly IUserAppService _userAppService;

        public EventsController(IUserAppService userAppService)
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