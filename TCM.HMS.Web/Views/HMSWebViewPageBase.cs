using Abp.Web.Mvc.Views;

namespace TCM.HMS.Web.Views
{
    public abstract class HMSWebViewPageBase : HMSWebViewPageBase<dynamic>
    {

    }

    public abstract class HMSWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected HMSWebViewPageBase()
        {
            LocalizationSourceName = HMSConsts.LocalizationSourceName;
        }
    }
}