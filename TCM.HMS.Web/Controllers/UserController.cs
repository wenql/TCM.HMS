using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCM.HMS.Application.User;
using TCM.HMS.Core.Helper;
using TCM.HMS.Core.Physique;

namespace TCM.HMS.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserAppService _iUserAppService;
        public UserController(IUserAppService iUserAppService)
        {
            this._iUserAppService = iUserAppService;
        }
        // GET: User
        public ActionResult Index()
        {
            ViewBag.ActiveMenu = "UserIndex";
            return View(this._iUserAppService.GetUsers().Select(xx =>
            {
                if (!string.IsNullOrEmpty(xx.PhysiqueScores))
                {
                    var tz = new List<int>();
                    var arr = xx.PhysiqueScores.Split(',').ToList();
                    var phz = arr.FirstOrDefault(x => int.Parse(x.Split('|')[0]) == (int)SubjectCategory.YinYangHarmony);
                    if (phz != null)
                    {
                        var other = arr.Where(x => int.Parse(x.Split('|')[0]) != (int) SubjectCategory.YinYangHarmony)
                            .ToList();
                        if (Convert.ToDouble(phz.Split('|')[1]) / Convert.ToDouble(32) * 100 >= 60 && other.All(x =>
                                Convert.ToDouble(x.Split('|')[1]) / Convert.ToDouble(32) * 100 < 40))
                        {
                            tz.Add((int) SubjectCategory.YinYangHarmony);
                        }

                        other.ForEach(x =>
                        {
                            if (Convert.ToDouble(x.Split('|')[1]) / Convert.ToDouble(32) * 100 >= 30)
                            {
                                tz.Add(int.Parse(x.Split('|')[0]));
                            }
                        });
                    }
                    var str = "";
                    if (tz.Any())
                    {
                        tz.ForEach(x => { str += EnumHelper.GetDescription((SubjectCategory)x) + ","; });
                    }
                    //var str = "";
                    //arr.ForEach(t =>
                    //{
                    //    var arr2 = t.Split('|');


                    //    str += EnumHelper.GetDescription((SubjectCategory)int.Parse(arr2[0])) + ",";
                    //    x.ExamResult = str.TrimEnd(',');
                    //});
                    xx.ExamResult = str.TrimEnd(',');
                }
                return xx;
            }).ToList());
        }
    }
}