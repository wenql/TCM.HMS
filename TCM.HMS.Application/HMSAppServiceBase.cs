using Abp.Application.Services;

namespace TCM.HMS
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class HMSAppServiceBase : ApplicationService
    {
        protected HMSAppServiceBase()
        {
            LocalizationSourceName = HMSConsts.LocalizationSourceName;
        }
    }
}