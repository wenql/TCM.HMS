using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Runtime.Session;
using Abp.UI;
using Abp.Web.Mvc.Controllers;
using Deepleo.Weixin.SDK;
using TCM.HMS.Application.Physique;
using TCM.HMS.Application.User;
using TCM.HMS.Application.User.Dto;
using TCM.HMS.Core.User;
using TCM.HMS.Application.Physique.Dto;
using TCM.HMS.Core.Physique;

namespace TCM.HMS.Web.Areas.WeiXin.Controllers
{
    public class SignHealthController : AbpController
    {
        private readonly IPhysiqueAppService _iPhysiqueAppService;
        private readonly IUserAppService _iUserAppService;
        private IAbpSession _abpSession { get; set; }

        public SignHealthController(IPhysiqueAppService iPhysiqueAppService, IUserAppService iUserAppService)
        {
            this._iPhysiqueAppService = iPhysiqueAppService;
            this._iUserAppService = iUserAppService;
            _abpSession = NullAbpSession.Instance;
        }

        // GET: WeiXin/SignHealth
        public ActionResult Index()
        {
            return View(this._iPhysiqueAppService.GetBootConfig());
        }

        public ActionResult SignUp()
        {
            //var code = Request.QueryString.Get("code");
            //if (string.IsNullOrEmpty(code))
            //{
            //    throw new UserFriendlyException("授权失败");
            //}
            //var access_token_scope = "";
            //double expires_in = 0;
            //var access_token = "";
            //var openId = "";
            //var token = OAuth2API.GetAccessToken(code, "wx25750ab6611b4901", "f178fca842e26a3563e168f7bfb15e58");
            //dynamic userinfo;

            //var refreshAccess_token = OAuth2API.RefreshAccess_token(token.refresh_token, "AppID");
            //access_token = refreshAccess_token.access_token;
            //openId = refreshAccess_token.openid;
            //access_token_scope = refreshAccess_token.scope;
            //expires_in = refreshAccess_token.expires_in;
            //userinfo = OAuth2API.GetUserInfo(access_token, openId);

            var user = new User { OpenId = "1" };
            user.Id = this._iUserAppService.SaveUserInfo(user);
            ViewBag.UserId = user.Id;

            return View();
        }

        /// <summary>
        /// Accept agreement
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Accept(UserDto user)
        {
            if (user.Id == 0)
            {
                return base.Json(new { success = false });
            }

            var userinfo = this._iUserAppService.GetUser(user.Id);
            if (userinfo == null)
            {
                return base.Json(new { success = false });
            }

            userinfo.UserName = user.UserName;
            userinfo.Sex = user.Sex;
            userinfo.BirthDay = user.BirthDay;
            userinfo.Mobile = user.Mobile;
            userinfo.IdCard = user.IdCard;
            this._iUserAppService.SaveUserInfo(userinfo);

            return base.Json(new { success = true, userId = userinfo.Id });
        }

        public JsonResult Score(int userId, List<ScoreResult> scores)
        {
            if (userId == 0)
            {
                return base.Json(new { success = false });
            }

            var userinfo = this._iUserAppService.GetUser(userId);
            if (userinfo == null)
            {
                return base.Json(new { success = false });
            }

            var str = "";
            scores.ForEach(x => str += (x.CategoryId + "|" + x.Score) + ",");
            userinfo.PhysiqueScores = str.TrimEnd(',');
            this._iUserAppService.SaveUserInfo(userinfo);

            return base.Json(new { success = true, userId = userinfo.Id });
        }

        /// <summary>
        /// 答题
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public ActionResult Exam(int userId)
        {
            var userinfo = this._iUserAppService.GetUser(userId);
            if (userinfo == null)
            {
                throw new UserFriendlyException("授权已过期");
            }

            ViewBag.UserId = userId;
            return View();
        }

        [HttpGet]
        public JsonResult GetSubject(int userId)
        {
            var userinfo = this._iUserAppService.GetUser(userId);
            if (userinfo == null)
            {
                throw new UserFriendlyException("授权已过期");
            }

            var data = this._iPhysiqueAppService.GetSubjects().ToList();
            var index = 1;
            data.ForEach(x =>
            {
                var arr = x.Scores.Split(',');
                x.Options = new List<SelectListItem>
                        {
                            new SelectListItem{Text="没有",Value=arr[0]},
                            new SelectListItem{Text="很少",Value=arr[1]},
                            new SelectListItem{Text="有时",Value=arr[2]},
                            new SelectListItem{Text="经常",Value=arr[3]},
                            new SelectListItem{Text="总是",Value=arr[4]}
                        };
                x.RowIndex = index;
                index++;
            });
            return base.Json(new
            {
                Data = data.FindAll(x => x.OnlySex == 2 || x.OnlySex == userinfo.Sex)
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Analysis(int userId)
        {
            var userinfo = this._iUserAppService.GetUser(userId);
            if (userinfo == null)
            {
                throw new UserFriendlyException("授权已过期");
            }

            if (string.IsNullOrEmpty(userinfo.PhysiqueScores))
            {
                return RedirectToAction("Index");
            }

            var arr = userinfo.PhysiqueScores.Split(',');
            var phz = arr.FirstOrDefault(x => int.Parse(x.Split('|')[0]) == (int)SubjectCategory.YinYangHarmony);
            if (phz == null)
            {
                return RedirectToAction("Index");
            }
            var other = arr.Where(x => int.Parse(x.Split('|')[0]) != (int)SubjectCategory.YinYangHarmony).ToList();

            var tz = new List<int>();
            if (Convert.ToDouble(phz.Split('|')[1]) / Convert.ToDouble(32) * 100 >= 60 && other.All(x => Convert.ToDouble(x.Split('|')[1]) / Convert.ToDouble(32) * 100 < 40))
            {
                tz.Add((int)SubjectCategory.YinYangHarmony);
            }

            other.ForEach(x =>
            {
                if (Convert.ToDouble(x.Split('|')[1]) / Convert.ToDouble(32) * 100 >= 30)
                {
                    tz.Add(int.Parse(x.Split('|')[0]));
                }
            });
            if (!tz.Any())
            {
                return RedirectToAction("Index");
            }
            return View(this._iPhysiqueAppService.GetDocuments(tz));
        }
    }
}