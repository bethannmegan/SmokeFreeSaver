//using SmokeFreeSaver.DataAccess.Models;
//using SmokeFreeSaver.DataAccess.Context;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace SmokeFreeSaver.DataAccess.Repositories
//{
//    public class SmokedTodayRepository
//    {
//        private SmokeFreeSaverDBContext _context;

//        public SmokedTodayRepository(SmokeFreeSaverDBContext context)
//        {
//            _context = context;
//        }

//        public int Create(SmokedTodayModel entry)
//        {

//            _context.Add(entry);
//            _context.SaveChanges();

//            return entry.ID;
//        }

//        public int Update(SmokedTodayModel entry)
//        {
//            SmokedTodayModel existingEntry = _context.SmokedTodayModel.Find(entry.ID);

//            existingEntry.CurrentDate = entry.CurrentDate;
//            existingEntry.NumberOfCigarettesSmoked = entry.NumberOfCigarettesSmoked;
//            existingEntry.NumberOfPacksBought = entry.NumberOfPacksBought;
//            existingEntry.CostPerPack = entry.CostPerPack;

//            _context.SaveChanges();

//            return existingEntry.ID;
//        }

//        public bool Delete(int ID)
//        {
//            SmokedTodayModel entry = _context.SmokedTodayModel.Find(ID);
//            _context.Remove(entry);
//            _context.SaveChanges();

//            return true;
//        }

//        public List<SmokedTodayModel> GetAllEntries()
//        {
//            List<SmokedTodayModel> entriesList = _context.SmokedTodayModel.ToList();

//            return entriesList;
//        }

//        public SmokedTodayModel GetEntryByID(int ID)
//        {
//            SmokedTodayModel entry = _context.SmokedTodayModel.Find(ID);

//            return entry;
//        }
//    }
//}
