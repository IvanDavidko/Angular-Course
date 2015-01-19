using System.Collections.Generic;
using System.Web.Mvc;

namespace PhotoManager.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Countries()
        {
            return
                Json(
                    new[]
                    {
                        new {name = "China", id = 1},
                        new {name = "India", id = 2},
                        new {name = "United States of America", id = 3}
                    }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Country1()
        {
            return
                Json(
                    new { name = "China", population = 1359821000, flagURL = @"//upload.wikimedia.org/wikipedia/commons/f/fa/Flag_of_the_People%27s_Republic_of_China.svg", capital = "Beijing", gdp = 12261 }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Country2()
        {
            return
                Json(
                    new { name = "India", population = 1205625000, flagURL = @"//upload.wikimedia.org/wikipedia/en/4/41/Flag_of_India.svg", capital = "New Delhi", gdp = 4716 }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Country3()
        {
            return
                Json(
                    new { name = "United States of America", population = 312247000, flagURL = @"//upload.wikimedia.org/wikipedia/en/a/a4/Flag_of_the_United_States.svg", capital = "Washington, D.C.", gdp = 16244 }, JsonRequestBehavior.AllowGet);
        }
    }
}