using Abp.Application.Navigation;
using Abp.Localization;
using TCM.HMS.Core;

namespace TCM.HMS.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See Views/Layout/_TopMenu.cshtml file to know how to render menu.
    /// </summary>
    public class HMSNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition("Physique", new LocalizableString("体质辨识", HMSConsts.LocalizationSourceName), icon: "fa fa-hospital-o")
                        .AddItem(new MenuItemDefinition("BootConfig", new LocalizableString("引导页", HMSConsts.LocalizationSourceName), icon: "fa fa-circle-o", url: "/physique/bootConfig"))
                        .AddItem(new MenuItemDefinition("Categories", new LocalizableString("体质分类", HMSConsts.LocalizationSourceName), icon: "fa fa-circle-o", url: "/physique/categories"))
                ).AddItem(new MenuItemDefinition("UserIndex", new LocalizableString("用户管理", HMSConsts.LocalizationSourceName), icon: "fa fa-user", url: "/user/index"));
        }
    }
}
