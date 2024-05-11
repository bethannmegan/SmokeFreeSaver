using SmokeFreeSaver.DataAccess.Context;
using SmokeFreeSaver.DataAccess.Models;
using SmokeFreeSaver.DataAccess.Repositories;

namespace SmokeFreeSaver.Models
{
    public class SmokeFreeSaverViewModel
    {
        private SmokeFreeSaverRepository _repo;

        public List<SmokeFreeSaverModel> EntryList { get; set; }

        public SmokeFreeSaverModel CurrentEntry { get; set; }

        public bool IsActionSuccess { get; set; }

        public string ActionMessage { get; set; }

        public decimal TotalSaved { get; set; }

        public SmokeFreeSaverViewModel(SmokeFreeSaverDBContext context)
        {
            _repo = new SmokeFreeSaverRepository(context);
            EntryList = GetAllEntries();
            CurrentEntry = EntryList.FirstOrDefault();
        }

        public SmokeFreeSaverViewModel(SmokeFreeSaverDBContext context, int id)
        {
            _repo = new SmokeFreeSaverRepository(context);
            EntryList = GetAllEntries();

            if (id > 0)
            {
                CurrentEntry = GetEntry(id);
            }
            else
            {
                CurrentEntry = new SmokeFreeSaverModel();
            }
        }

        public void SaveEntry(SmokeFreeSaverModel entry)
        {
            if (entry.ID > 0)
            {
                _repo.Update(entry);
            }
            else
            {
                entry.ID = _repo.Create(entry);
            }

            EntryList = GetAllEntries();
            CurrentEntry = GetEntry(entry.ID);
        }

        public List<SmokeFreeSaverModel> GetAllEntries()
        {
            return _repo.GetAllEntries();
        }

        public SmokeFreeSaverModel GetEntry(int id)
        {
            return _repo.GetEntryByID(id);
        }

        private int GetNextId()
        {
            int id = 1;
            var entries = GetAllEntries();

            if (entries != null && entries.Any())
            {
                entries = entries.OrderByDescending(e => e.ID).ToList();
                id = entries[0].ID + 1;
            }
            return id;
        }


    }
}
