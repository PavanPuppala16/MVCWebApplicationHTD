using Microsoft.AspNetCore.Mvc;

namespace MVCWebApplicationHTD.Controllers
{
    public class SecondExViewController : Controller
    {
        public IActionResult StoreData()
        {
            return View();
        }
    }
}
