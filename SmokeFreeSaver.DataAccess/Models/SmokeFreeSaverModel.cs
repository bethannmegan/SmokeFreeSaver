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

        public int NumberOfCigarettesSmoked { get; set; }

        public int NumberOfCigarettesNotSmoked { get; set; }

        public int NumberOfPacksBought { get; set; }

        public decimal CostPerPack { get; set; }


        public SmokeFreeSaverModel(int id, DateOnly currentDate, int numberOfCigarettesSmoked, int numberOfCigarettesNotSmoked, int numberOfPacksBought, decimal costPerPack)
        {
            ID = id;
            CurrentDate = currentDate;
            NumberOfCigarettesSmoked = numberOfCigarettesSmoked;
            NumberOfCigarettesNotSmoked = numberOfCigarettesNotSmoked;
            NumberOfPacksBought = numberOfPacksBought;
            CostPerPack = costPerPack;
        }

        public SmokeFreeSaverModel()
        {

        }
    }
}
