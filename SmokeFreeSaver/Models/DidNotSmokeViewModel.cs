//using SmokeFreeSaver.DataAccess.Context;
//using SmokeFreeSaver.DataAccess.Models;
//using SmokeFreeSaver.DataAccess.Repositories;

//namespace SmokeFreeSaver.Models
//{
//    public class DidNotSmokeViewModel
//    {
//        private SmokeFreeSaverRepository _repo;

//        public List<SmokeFreeSaverModel> EntryList { get; set; }

//        public SmokeFreeSaverModel CurrentEntry { get; set; }

//        public bool IsActionSuccess { get; set; }

//        public string ActionMessage { get; set; }

//        public DidNotSmokeViewModel(SmokeFreeSaverDBContext context)
//        {
//            _repo = new SmokeFreeSaverRepository(context);
//            EntryList = GetAllEntries();
//            CurrentEntry = EntryList.FirstOrDefault();
//        }

//        public DidNotSmokeViewModel(SmokeFreeSaverDBContext context, int Id)
//        {
//            _repo = new SmokeFreeSaverRepository(context);
//            EntryList = GetAllEntries();

//            if (Id > 0)
//            {
//                CurrentEntry = GetEntry(Id);
//            }
//            else
//            {
//                CurrentEntry = new SmokeFreeSaverModel();
//            }
//        }

//        public void SaveEntry(SmokeFreeSaverModel entry)
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

//        public List<SmokeFreeSaverModel> GetAllEntries()
//        {
//            return _repo.GetAllEntries();
//        }

//        public SmokeFreeSaverModel GetEntry(int ID)
//        {
//            return _repo.GetEntryByID(ID);
//        }
//    }
//}
