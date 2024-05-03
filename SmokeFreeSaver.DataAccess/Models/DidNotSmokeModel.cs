//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SmokeFreeSaver.DataAccess.Models
//{
//    public class DidNotSmokeModel
//    {
//        [Key]
//        public int ID { get; set; }

//        public DateOnly CurrentDate { get; set; }

//        public int NumberOfCigarettesNotSmoked { get; set; }

//        public decimal CostPerPack { get; set; }


//        public DidNotSmokeModel(int id, DateOnly currentDate, int numberOfCigarettesNotSmoked, decimal costPerPack)
//        {
//            ID = id;
//            CurrentDate = currentDate;
//            NumberOfCigarettesNotSmoked = numberOfCigarettesNotSmoked;
//            CostPerPack = costPerPack;
//        }

//        public DidNotSmokeModel()
//        {

//        }
//    }
//}
