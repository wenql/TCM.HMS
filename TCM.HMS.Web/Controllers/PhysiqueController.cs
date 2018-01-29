using Abp.UI;
using Abp.Web.Models;
using System.Threading.Tasks;
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

        // GET: Config
        public ActionResult BootConfig()
        {
            return View(this._iPhysiqueAppService.GetBootConfig());
        }

        // POST: Config
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

        // GET:Categories
        public ActionResult Categories()
        {
            return View();
        }
    }
}