using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokeFreeSaver.DataAccess.Models
{
    public class SmokeFreeSaverModel
    {
        [Key]
        public int ID { get; set; }

        public DateOnly CurrentDate { get; set; }

        public DateOnly? EndDate { get; set; }

        public int NumberOfCigarettesSmoked {  get; set; }

        public int NumberOfPacksBought { get; set; }


        public SmokeFreeSaverModel(int id, DateOnly currentDate, DateOnly endDate, int numberOfCigarettesSmoked, int numberOfPacksBought)
        {
            ID = id;
            CurrentDate = currentDate;
            EndDate = endDate;
            NumberOfCigarettesSmoked = numberOfCigarettesSmoked;
            NumberOfPacksBought = numberOfPacksBought;
        }

        public SmokeFreeSaverModel()
        {

        }
    }
}
