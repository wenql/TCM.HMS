using System.Web.Mvc;

namespace TCM.HMS.Web.Controllers
{
    public class AboutController : HMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}