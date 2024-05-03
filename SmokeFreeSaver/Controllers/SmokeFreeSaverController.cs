//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
//using SmokeFreeSaver.DataAccess.Context;
//using SmokeFreeSaver.DataAccess.Models;
//using SmokeFreeSaver.Models;

//namespace SmokeFreeSaver.Controllers
//{
//    public class SmokeFreeSaverController : Controller
//    {
//        private SmokeFreeSaverDBContext _context;

//        public SmokeFreeSaverController(SmokeFreeSaverDBContext context)
//        {
//            _context = context;
//        }

//        public IActionResult Index() 
//        { 
//            SmokeFreeSaverViewModel model = new SmokeFreeSaverViewModel(_context);
//            return View(model);
//        }

//        [HttpPost]
//        public IActionResult SmokedToday(int id, DateOnly currentDate, DateOnly endDate)
//        {
//            SmokedTodayViewModel model = new SmokedTodayViewModel(_context);

//            SmokeFreeSaverModel entry = new(id, currentDate, endDate);

//            model.SaveEntry(entry);
//            model.IsActionSuccess = true;
//            model.ActionMessage = "Entry has been saved successfully!";

//            return View(model);
//        }

//        [HttpPost]
//        public IActionResult DidNotSmoke(int id, DateOnly currentDate, DateOnly endDate)
//        {
//            DidNotSmokeViewModel model = new DidNotSmokeViewModel(_context);

//            SmokeFreeSaverModel entry = new(id, currentDate, endDate);

//            model.SaveEntry(entry);
//            model.IsActionSuccess = true;
//            model.ActionMessage = "Entry has been saved successfully!";

//            return View(model);
//        }

//        public IActionResult Update(int id)
//        {
//            SmokeFreeSaverViewModel model = new SmokeFreeSaverViewModel(_context, id);
//            return View(model);
//        }
//    }
//}
