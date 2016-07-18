using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace QrF.XXProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : XXProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}