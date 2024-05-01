//using SmokeFreeSaver.DataAccess.Context;
//using SmokeFreeSaver.DataAccess.Models;
//using SmokeFreeSaver.DataAccess.Repositories;

//namespace SmokeFreeSaver.Models
//{
//    public class DidNotSmokeViewModel
//    {
//        private DidNotSmokeRepository _repo;

//        public List<DidNotSmokeModel> EntryList { get; set; }

//        public DidNotSmokeModel CurrentEntry { get; set; }

//        public bool IsActionSuccess { get; set; }

//        public string ActionMessage { get; set; }

//        public DidNotSmokeViewModel(SmokeFreeSaverDBContext context)
//        {
//            _repo = new DidNotSmokeRepository(context);
//            EntryList = GetAllEntries();
//            CurrentEntry = EntryList.FirstOrDefault();
//        }

//        public DidNotSmokeViewModel(SmokeFreeSaverDBContext context, int Id)
//        {
//            _repo = new DidNotSmokeRepository(context);
//            EntryList = GetAllEntries();

//            if (Id > 0)
//            {
//                CurrentEntry = GetEntry(Id);
//            }
//            else
//            {
//                CurrentEntry = new DidNotSmokeModel();
//            }
//        }

//        public void SaveEntry(DidNotSmokeModel entry)
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

//        public List<DidNotSmokeModel> GetAllEntries()
//        {
//            return _repo.GetAllEntries();
//        }

//        public DidNotSmokeModel GetEntry(int ID)
//        {
//            return _repo.GetEntryByID(ID);
//        }
//    }
//}
