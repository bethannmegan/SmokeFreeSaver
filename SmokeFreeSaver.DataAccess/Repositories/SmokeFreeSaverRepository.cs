using SmokeFreeSaver.DataAccess.Models;
using SmokeFreeSaver.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SmokeFreeSaver.DataAccess.Repositories
{
    public class SmokeFreeSaverRepository
    {
        private SmokeFreeSaverDBContext _context;

        public SmokeFreeSaverRepository(SmokeFreeSaverDBContext context)
        {
            _context = context;
        }

        public int Create(SmokeFreeSaverModel entry)
        {

            _context.Add(entry);
            _context.SaveChanges();

            return entry.ID;
        }

        public int Update(SmokeFreeSaverModel entry)
        {
            SmokeFreeSaverModel existingEntry = _context.SmokeFreeSaverModel.Find(entry.ID);

            existingEntry.CurrentDate = entry.CurrentDate;
            existingEntry.NumberOfCigarettesSmoked = entry.NumberOfCigarettesSmoked;
            existingEntry.NumberOfCigarettesNotSmoked = entry.NumberOfCigarettesNotSmoked;
            existingEntry.NumberOfPacksBought = entry.NumberOfPacksBought;
            existingEntry.CostPerPack = entry.CostPerPack;

            _context.SaveChanges();

            return existingEntry.ID;
        }

        public bool Delete(int ID)
        {
            SmokeFreeSaverModel entry = _context.SmokeFreeSaverModel.Find(ID);
            _context.Remove(entry);
            _context.SaveChanges();

            return true;
        }

        public List<SmokeFreeSaverModel> GetAllEntries()
        {
            List<SmokeFreeSaverModel> entriesList = _context.SmokeFreeSaverModel.ToList();

            return entriesList;
        }

        public SmokeFreeSaverModel GetEntryByID(int ID)
        {
            SmokeFreeSaverModel entry = _context.SmokeFreeSaverModel.Find(ID);

            return entry;
        }

    }
}
