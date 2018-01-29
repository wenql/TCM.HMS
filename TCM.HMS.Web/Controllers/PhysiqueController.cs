using System;
using Abp.UI;
using Abp.Web.Models;
using System.Threading.Tasks;
using System.Web.Mvc;
using TCM.HMS.Application.Physique;
using TCM.HMS.Application.Physique.Dto;
using TCM.HMS.Core.Helper;
using TCM.HMS.Core.Physique;

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
            ViewBag.ActiveMenu = "BootConfig";
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
            ViewBag.ActiveMenu = "Categories";
            return View(EnumHelper.GetEnumList<SubjectCategory>());
        }

        // GET:Subject
        public ActionResult Subject(int categoryId)
        {
            ViewBag.ActiveMenu = "Categories";
            if (!Enum.IsDefined(typeof(SubjectCategory), categoryId))
            {
                throw new UserFriendlyException("体质分类不存在");
            }

            return View(new PhysiqueSubjects
            {
                CategoryId = categoryId,
                Subjects = this._iPhysiqueAppService.GetSubjects(categoryId)
            });
        }

        public ActionResult SubjectForm(int categoryId = 0, int id = 0)
        {
            ViewBag.ActiveMenu = "Categories";
            var model = new SubjectDto { CategoryId = categoryId };
            if (id > 0)
            {
                model = this._iPhysiqueAppService.GetSubject(id) ?? throw new UserFriendlyException("记录不存在");
                var arr = model.Scores.Split(',');
                model.Score1 = int.Parse(arr[0]);
                model.Score2 = int.Parse(arr[1]);
                model.Score3 = int.Parse(arr[2]);
                model.Score4 = int.Parse(arr[3]);
                model.Score5 = int.Parse(arr[4]);
            }
            else
            {
                if (!Enum.IsDefined(typeof(SubjectCategory), categoryId))
                {
                    throw new UserFriendlyException("体质分类不存在");
                }
            }
            return View(model);
        }

        public async Task<JsonResult> SubmitSubject(SubjectDto model)
        {
            if (!ModelState.IsValid)
            {
                throw new UserFriendlyException(base.GetModelStateErrorInfo());
            }
            this._iPhysiqueAppService.SaveSubject(model);
            return Json(new AjaxResponse { });
        }

        public async Task<JsonResult> DelSubject(int id)
        {
            this._iPhysiqueAppService.DeleteSubject(id);
            return Json(new AjaxResponse { });
        }

        public ActionResult Document(int categoryId)
        {
            ViewBag.ActiveMenu = "Categories";
            if (!Enum.IsDefined(typeof(SubjectCategory), categoryId))
            {
                throw new UserFriendlyException("体质分类不存在");
            }

            return View(this._iPhysiqueAppService.GetDocument(categoryId) ?? new DocumentDto { CategoryId = categoryId });
        }

        [HttpPost]
        public async Task<JsonResult> SubmitDocument(DocumentDto model)
        {
            if (!ModelState.IsValid)
            {
                throw new UserFriendlyException(base.GetModelStateErrorInfo());
            }
            this._iPhysiqueAppService.SaveDocument(model);
            return Json(new AjaxResponse { });
        }
    }
}