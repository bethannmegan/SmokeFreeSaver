//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
//using SmokeFreeSaver.DataAccess.Context;
//using SmokeFreeSaver.DataAccess.Models;
//using SmokeFreeSaver.Models;

//namespace SmokeFreeSaver.Controllers
//{
//    public class SmokedTodayController : Controller
//    {
//        private SmokeFreeSaverDBContext _context;

//        public SmokedTodayController(SmokeFreeSaverDBContext context)
//        {
//            _context = context;
//        }

//        public IActionResult Index()
//        {
//            SmokedTodayViewModel model = new SmokedTodayViewModel(_context);
//            return View(model);
//        }

//        [HttpPost]
//        public IActionResult Index(int ID, DateOnly currentDate, int numberOfCigarettesSmoked, int numberOfPacksBought, decimal costPerPack)
//        {
//            SmokedTodayViewModel model = new SmokedTodayViewModel(_context);

//            SmokedTodayModel entry = new(ID, currentDate, numberOfCigarettesSmoked, numberOfPacksBought, costPerPack);

//            model.SaveEntry(entry);
//            model.IsActionSuccess = true;
//            model.ActionMessage = "Entry has been saved successfully!";

//            return View(model);
//        }

//        public IActionResult Update(int id)
//        {
//            SmokedTodayViewModel model = new SmokedTodayViewModel(_context, id);
//            return View(model);
//        }

//    }
//}
