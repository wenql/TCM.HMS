using System.Web.Mvc;

namespace TCM.HMS.Web.Controllers
{
    public class HomeController : HMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}