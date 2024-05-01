//using SmokeFreeSaver.DataAccess.Models;
//using SmokeFreeSaver.DataAccess.Context;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace SmokeFreeSaver.DataAccess.Repositories
//{
//    public class DidNotSmokeRepository
//    {
//        private SmokeFreeSaverDBContext _context;

//        public DidNotSmokeRepository(SmokeFreeSaverDBContext context)
//        {
//            _context = context;
//        }

//        public int Create(DidNotSmokeModel entry)
//        {

//            _context.Add(entry);
//            _context.SaveChanges();

//            return entry.ID;
//        }

//        public int Update(DidNotSmokeModel entry)
//        {
//            DidNotSmokeModel existingEntry = _context.DidNotSmokeModel.Find(entry.ID);

//            existingEntry.CurrentDate = entry.CurrentDate;
//            existingEntry.NumberOfCigarettesNotSmoked = entry.NumberOfCigarettesNotSmoked;
//            existingEntry.CostPerPack = entry.CostPerPack;

//            _context.SaveChanges();

//            return existingEntry.ID;
//        }

//        public bool Delete(int ID)
//        {
//            DidNotSmokeModel entry = _context.DidNotSmokeModel.Find(ID);
//            _context.Remove(entry);
//            _context.SaveChanges();

//            return true;
//        }

//        public List<DidNotSmokeModel> GetAllEntries()
//        {
//            List<DidNotSmokeModel> entriesList = _context.DidNotSmokeModel.ToList();

//            return entriesList;
//        }

//        public DidNotSmokeModel GetEntryByID(int ID)
//        {
//            DidNotSmokeModel entry = _context.DidNotSmokeModel.Find(ID);

//            return entry;
//        }
//    }
//}
