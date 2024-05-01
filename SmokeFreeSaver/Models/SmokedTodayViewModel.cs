//using SmokeFreeSaver.DataAccess.Context;
//using SmokeFreeSaver.DataAccess.Models;
//using SmokeFreeSaver.DataAccess.Repositories;

//namespace SmokeFreeSaver.Models
//{
//    public class SmokedTodayViewModel
//    {
//        private SmokedTodayRepository _repo;

//        public List<SmokedTodayModel> EntryList { get; set; }

//        public SmokedTodayModel CurrentEntry { get; set; }

//        public bool IsActionSuccess { get; set; }

//        public string ActionMessage { get; set; }

//        public SmokedTodayViewModel(SmokeFreeSaverDBContext context)
//        {
//            _repo = new SmokedTodayRepository(context);
//            EntryList = GetAllEntries();
//            CurrentEntry = EntryList.FirstOrDefault();
//        }

//        public SmokedTodayViewModel(SmokeFreeSaverDBContext context, int Id)
//        {
//            _repo = new SmokedTodayRepository(context);
//            EntryList = GetAllEntries();

//            if (Id > 0)
//            {
//                CurrentEntry = GetEntry(Id);
//            }
//            else
//            {
//                CurrentEntry = new SmokedTodayModel();
//            }
//        }

//        public void SaveEntry(SmokedTodayModel entry)
//        {
//            if (entry.ID > 0)
//            {
//                _repo.Update(entry);
//            }
//            else
//            {
//                entry.ID = _repo.Create(entry);
//            }

//            EntryList = GetAllEntries();
//            CurrentEntry = GetEntry(entry.ID);
//        }

//        public List<SmokedTodayModel> GetAllEntries()
//        {
//            return _repo.GetAllEntries();
//        }

//        public SmokedTodayModel GetEntry(int ID)
//        {
//            return _repo.GetEntryByID(ID);
//        }

//        private int GetNextId()
//        {
//            int id = 1;
//            var entries = GetAllEntries();

//            if (entries != null && entries.Any())
//            {
//                entries = entries.OrderByDescending(e => e.ID).ToList();
//                id = entries[0].ID + 1;
//            }
//            return id;
//        }
//    }
//}
