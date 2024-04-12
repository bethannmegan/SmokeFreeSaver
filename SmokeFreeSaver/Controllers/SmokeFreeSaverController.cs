using Microsoft.AspNetCore.Mvc;

namespace SmokeFreeSaver.Controllers
{
    public class SmokeFreeSaverController : Controller
    {
        //method logic goes here
        public IActionResult Index()
        {
            return View();
        }
    }
}
