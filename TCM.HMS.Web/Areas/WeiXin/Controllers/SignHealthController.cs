using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCM.HMS.Application.Physique;

namespace TCM.HMS.Web.Areas.WeiXin.Controllers
{
    public class SignHealthController : Controller
    {
        private readonly IPhysiqueAppService _iPhysiqueAppService;

        public SignHealthController(IPhysiqueAppService iPhysiqueAppService)
        {
            this._iPhysiqueAppService = iPhysiqueAppService;
        }

        // GET: WeiXin/SignHealth
        public ActionResult Index()
        {
            return View(this._iPhysiqueAppService.GetBootConfig());
        }

        public ActionResult SignUp()
        {
            return View();
        }

        /// <summary>
        /// Accept agreement
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Accept()
        {
            return null;
        }
    }
}