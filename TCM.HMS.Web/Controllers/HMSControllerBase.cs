using Abp.Web.Mvc.Controllers;

namespace TCM.HMS.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class HMSControllerBase : AbpController
    {
        protected HMSControllerBase()
        {
            LocalizationSourceName = HMSConsts.LocalizationSourceName;
        }
    }
}