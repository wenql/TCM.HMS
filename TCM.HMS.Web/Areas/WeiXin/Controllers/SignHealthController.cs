using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TCM.HMS.Web.Areas.WeiXin.Controllers
{
    public class SignHealthController : Controller
    {
        // GET: WeiXin/SignHealth
        public ActionResult Index()
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