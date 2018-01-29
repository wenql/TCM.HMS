using Abp.UI;
using Abp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TCM.HMS.Application.Physique;
using TCM.HMS.Application.Physique.Dto;

namespace TCM.HMS.Web.Controllers
{
    public class PhysiqueController : HMSControllerBase
    {
        private readonly IPhysiqueAppService _iPhysiqueAppService;

        public PhysiqueController(IPhysiqueAppService iPhysiqueAppService)
        {
            this._iPhysiqueAppService = iPhysiqueAppService;
        }

        // GET: Physique
        public ActionResult BootConfig()
        {
            return View(this._iPhysiqueAppService.GetBootConfig());
        }

        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<JsonResult> SubmitConfig(BootConfigDto model)
        {
            if (!ModelState.IsValid)
            {
                throw new UserFriendlyException(base.GetModelStateErrorInfo());
            }
            this._iPhysiqueAppService.SaveConfig(model);
            return Json(new AjaxResponse { });
        }
    }
}