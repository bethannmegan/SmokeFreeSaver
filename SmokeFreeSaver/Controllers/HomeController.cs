using Microsoft.AspNetCore.Mvc;
using SmokeFreeSaver.DataAccess.Context;
using SmokeFreeSaver.DataAccess.Models;
using SmokeFreeSaver.Models;
using System.Diagnostics;

namespace SmokeFreeSaver.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private SmokeFreeSaverDBContext _context;

        public HomeController(ILogger<HomeController> logger, SmokeFreeSaverDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            SmokeFreeSaverViewModel model = new SmokeFreeSaverViewModel(_context);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Index(int ID, DateOnly currentDate, int numberOfCigarettesSmoked, int numberOfCigarettesNotSmoked, int numberOfPacksBought, decimal costPerPack)
        {
            SmokeFreeSaverViewModel model = new SmokeFreeSaverViewModel(_context);

            SmokeFreeSaverModel entry = new(ID, currentDate, numberOfCigarettesSmoked, numberOfCigarettesNotSmoked, numberOfPacksBought, costPerPack);

            model.SaveEntry(entry);
            model.IsActionSuccess = true;
            model.ActionMessage = "Entry has been saved successfully!";

            return View(model);
        }

        public IActionResult Update(int id)
        {
            SmokeFreeSaverViewModel model = new SmokeFreeSaverViewModel(_context, id);
            return View(model);
        }
    }
}
