using Microsoft.AspNetCore.Mvc;
using MVCWebApplicationHTD.Models;
using MVCWebApplicationHTD.Business_Logic;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace MVCWebApplicationHTD.Controllers
{
    public class calculatorController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(calculator3 OBJ)
        {
            if (ModelState.IsValid)
            {
                bool res = Operation_bl.Insert(OBJ);
                if (res == true)
                {

                    return View();

                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
            return View();
        }
    }
}