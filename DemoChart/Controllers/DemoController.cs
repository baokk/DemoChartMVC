using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoChart.Controllers
{
    public class DemoController : Controller
    {
        List<int> lstOrderHY = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
        List<int> lstOrderHN = new List<int> { 3, 2, 5, 4, 5, 4, 7, 8, 9, 3, 7, 9 };
        //
        // GET: /Demo/
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult LoadOrder(string location)
        {
            if (location == "HY")
            {
                return Json(new { Items = lstOrderHY.ToList() }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Items = lstOrderHN.ToList() }, JsonRequestBehavior.AllowGet);
            }
            
        }
	}
}