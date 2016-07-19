using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using QrF.XXProject.Authorization;
using QrF.XXProject.Users;
using QrF.XXProject.Events;
using QrF.XXProject.Events.Dto;

namespace QrF.XXProject.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class EventsController : XXProjectControllerBase
    {
        private readonly IEventAppService _eventAppService;

        public EventsController(IEventAppService userAppService)
        {
            _eventAppService = userAppService;
        }

        public async Task<ActionResult> Index()
        {
            var input = new GetEventListInput() { IncludeCanceledEvents=false };
            var output = await _eventAppService.GetList(input);
            return View(output);
        }
    }
}