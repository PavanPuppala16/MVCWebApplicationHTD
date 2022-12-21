using Microsoft.AspNetCore.Mvc;
using MVCWebApplicationHTD.Models;

namespace MVCWebApplicationHTD.Controllers
{
    public class ExViewController : Controller
    {
        public IActionResult ExonViewData()
        {
            ViewData["vd"] = "I Am Pavan kumar puppala using viewdata";
            ViewBag.vb = "I Am pavan kumar puppala using viewbag";
            TempData["td"] = "I Am pavan kumar puppala using temp data";
            return View();
            //return RedirectToAction("StoreData", "SecondExView");
            
        }
        public ActionResult ViewDataEx()
        {
            List<viewDataModelcs> emplist = new List<Models.viewDataModelcs>();
            emplist.Add(
                new viewDataModelcs
                {
                    Eid = 1,
                    Name = "pavan",
                    Address = "Hyd"
                });
            emplist.Add(
                new viewDataModelcs { Eid = 2, Name = "Anu", Address = "Banglore" });
            emplist.Add(
                new viewDataModelcs { Eid = 3, Name = "Sam", Address = "Delhi" });
            TempData["EmpList"] = emplist;
            return View();
        }
    }
}
