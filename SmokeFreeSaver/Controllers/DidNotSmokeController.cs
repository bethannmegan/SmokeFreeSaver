//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
//using SmokeFreeSaver.DataAccess.Context;
//using SmokeFreeSaver.DataAccess.Models;
//using SmokeFreeSaver.Models;

//namespace SmokeFreeSaver.Controllers
//{
//    public class DidNotSmokeController : Controller
//    {
//        private SmokeFreeSaverDBContext _context;

//        public DidNotSmokeController(SmokeFreeSaverDBContext context)
//        {
//            _context = context;
//        }

//        public IActionResult Index()
//        {
//            DidNotSmokeViewModel model = new DidNotSmokeViewModel(_context);
//            return View(model);
//        }

//        [HttpPost]
//        public IActionResult Index(int ID, DateOnly currentDate, int numberOfCigarettesNotSmoked, decimal costPerPack)
//        {
//            DidNotSmokeViewModel model = new DidNotSmokeViewModel(_context);

//            DidNotSmokeModel entry = new(ID, currentDate, numberOfCigarettesNotSmoked, costPerPack);

//            model.SaveEntry(entry);
//            model.IsActionSuccess = true;
//            model.ActionMessage = "Entry has been saved successfully!";

//            return View(model);
//        }

//        public IActionResult Update(int id)
//        {
//            DidNotSmokeViewModel model = new DidNotSmokeViewModel(_context, id);
//            return View(model);
//        }

//    }
//}
