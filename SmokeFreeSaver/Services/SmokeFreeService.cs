using System.Reflection.Metadata.Ecma335;

namespace SmokeFreeSaver.Services
{
    public class SmokeFreeService
    {
        public static decimal costPerPack;

        public static int cigarettesPerPack = 20;

        //public bool DidYouSmokeToday(bool response)
        //{
        //    if (response == true)
        //    {
        //        totalSavings - costPerPack;

        //    }
        //    if (response == false)
        //    {
        //        totalSavings += CalculateSavingsPerDay;

        //    }
        //}

            private static decimal CalculateSavingsPerDay(int cigarettesPerDay, decimal costPerPack)
            {
                decimal savingsPerDay = (cigarettesPerDay / cigarettesPerPack) * costPerPack;

                return savingsPerDay;
            }

            public decimal MoneySpentOnPacks(int packsBoughtToday)
            {
            return packsBoughtToday * costPerPack; 
            }

        
    }
}

