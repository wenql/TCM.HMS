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
                );

            bundles.Add(
                new ScriptBundle("~/Bundles/Scripts/Required")
                    .Include(
                        "~/Scripts/jquery.min.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/jquery.slimscroll.min.js",
                        "~/Scripts/fastclick.js",
                        "~/Scripts/adminlte.min.js"
                    )
                );
        }
    }
}