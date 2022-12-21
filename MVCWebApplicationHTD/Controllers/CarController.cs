using Microsoft.AspNetCore.Mvc;
using MVCWebApplicationHTD.Business_Logic;
using MVCWebApplicationHTD.Models;


namespace MVCWebApplicationHTD.Controllers
{
    public class CarController : Controller
    {
        public IActionResult InsertCar()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult InsertCar(CarModelcs obj)
        {
            ViewBag.Message = "formsubmitted";
            if (ModelState.IsValid)
            {
                bool res = InsertCarData.Insertdata(obj);

                if (res == true)
                {

                    return View();
                }
                else
                {
                    return View(obj);
                }
            }
            else
            {
                return View(obj);
            }
        }
        [HttpGet]
       
        public IActionResult Displaycar()
        {
            return View(InsertCarData.GetAllData());
        }
        public IActionResult UPDATE(string? cartype)
        {
            return View(InsertCarData.GetDataByCARTYPE);
        }


        public IActionResult UPDATE(CarModelcs obj)
        {
            if (ModelState.IsValid)
            {
                bool res = InsertCarData.UPDATEDATA(obj);
                if (res == true)
                {
                    return RedirectToAction("UPDATE","Displaycar","Car");
                }
                else
                {
                    return View(obj);
                }
            }
            else
            {
                return View(obj);
            }
        }
        public IActionResult DELETE(string? cartype)
        {
            bool res = InsertCarData.DELETEDATA((string) cartype);
            if (res == true)
            {
                return RedirectToAction("Displaycar","Car");
            }
            else
            {
                return View();
            }

            return View();
        }

    }
}


