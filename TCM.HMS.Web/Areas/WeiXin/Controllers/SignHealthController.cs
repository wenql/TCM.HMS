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
            //var token = OAuth2API.GetAccessToken(code, "AppID", "AppSecret");
            //dynamic userinfo;

            //var refreshAccess_token = OAuth2API.RefreshAccess_token(token.refresh_token, "AppID");
            //access_token = refreshAccess_token.access_token;
            //openId = refreshAccess_token.openid;
            //access_token_scope = refreshAccess_token.scope;
            //expires_in = refreshAccess_token.expires_in;
            //userinfo = OAuth2API.GetUserInfo(access_token, openId);

            var user = new UserDto { OpenId = "1" };
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
    }
}