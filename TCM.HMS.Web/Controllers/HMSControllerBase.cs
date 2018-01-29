using Abp.Web.Mvc.Controllers;
using System.Text;
using TCM.HMS.Core;

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
        public string GetModelStateErrorInfo()
        {
            var errinfo = new StringBuilder();
            foreach (var s in ModelState.Values)
            {
                foreach (var p in s.Errors)
                {
                    errinfo.AppendFormat("{0}<br/>", p.ErrorMessage);
                }
            }
            return errinfo.ToString();
        }

    }
}