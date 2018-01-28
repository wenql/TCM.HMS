using Abp.Localization;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Modules;
using Abp.Web.Mvc;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace TCM.HMS.Web
{
    [DependsOn(
        typeof(AbpWebMvcModule),
        typeof(HMSDataModule), 
        typeof(HMSApplicationModule), 
        typeof(HMSWebApiModule))]
    public class HMSWebModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Configure navigation/menu
            Configuration.Navigation.Providers.Add<HMSNavigationProvider>();
            Configuration.Localization.IsEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
