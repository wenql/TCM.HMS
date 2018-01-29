using System.Web.Optimization;

namespace TCM.HMS.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            bundles.Add(
                new StyleBundle("~/Bundles/Styles/Adminlte")
                    .Include("~/Content/bootstrap.min.css", new CssRewriteUrlTransform())
                    .Include("~/Content/font-awesome.min.css", new CssRewriteUrlTransform())
                    .Include("~/Content/AdminLTE.min.css", new CssRewriteUrlTransform())
                    .Include("~/Content/skins/_all-skins.css", new CssRewriteUrlTransform())
                    .Include("~/Content/toastr.css", new CssRewriteUrlTransform())
                    .Include("~/Content/sweetalert.css", new CssRewriteUrlTransform())
                );

            bundles.Add(
                new ScriptBundle("~/Bundles/Scripts/Required")
                    .Include(
                        "~/Scripts/jquery.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/jquery.slimscroll.min.js",
                        "~/Scripts/fastclick.js",
                        "~/Scripts/adminlte.min.js"
                    )
                );

            bundles.Add(
               new ScriptBundle("~/Bundles/Scripts/Plugin")
                   .Include(
                        "~/Scripts/jquery.js",
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.validate.unobtrusive.min.js",
                        "~/Scripts/jquery.blockUI.js",
                        "~/Scripts/toastr.js",
                        "~/Scripts/sweetalert-dev.js",
                        "~/Scripts/spin.min.js",
                        "~/Scripts/jquery.spin.js",
                        "~/Abp/Framework/scripts/abp.js",
                        "~/Abp/Framework/scripts/libs/abp.jquery.js",
                        "~/Abp/Framework/scripts/libs/abp.toastr.js",
                        "~/Abp/Framework/scripts/libs/abp.blockUI.js",
                        "~/Abp/Framework/scripts/libs/abp.spin.js",
                        "~/Abp/Framework/scripts/libs/abp.sweet-alert.js"
                   )
               );
        }
    }
}