using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Controllers;

namespace TCM.HMS.Web.Admin.Controllers
{
    public class BaseAdminController : AbpController
    {
        protected BaseAdminController()
        {
            LocalizationSourceName = HMSConsts.LocalizationSourceName;
        }
    }
}