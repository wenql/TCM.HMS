using System.Web.Mvc;
using Abp.Application.Navigation;
using Abp.Runtime.Session;
using Abp.Threading;
using TCM.HMS.Web.Models.Layout;

namespace TCM.HMS.Web.Controllers
{
    public class LayoutController : HMSControllerBase
    {
        private readonly IUserNavigationManager _userNavigationManager;

        /// <summary>
        /// Layout
        /// </summary>
        /// <param name="userNavigationManager"></param>
        public LayoutController(IUserNavigationManager userNavigationManager)
        {
            _userNavigationManager = userNavigationManager;
        }

        /// <summary>
        /// getSidebar
        /// </summary>
        /// <param name="activeMenu"></param>
        /// <returns></returns>
        [ChildActionOnly]
        public PartialViewResult SideBarNav(string activeMenu = "")
        {
            var model = new SideBarNavViewModel
            {
                MainMenu = AsyncHelper.RunSync(() => _userNavigationManager.GetMenuAsync("MainMenu", AbpSession.ToUserIdentifier())),
                ActiveMenuItemName = activeMenu
            };

            return PartialView("_SideBarNav", model);
        }
    }
}