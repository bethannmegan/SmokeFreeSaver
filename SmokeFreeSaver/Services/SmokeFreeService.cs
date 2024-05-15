using System.Reflection.Metadata.Ecma335;

namespace SmokeFreeSaver.Services
{
    public static class SmokeFreeService
    {
        public static decimal costPerPack = 10.00M;

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

            public static decimal CalculateSavingsPerDay(int cigarettesPerDay, decimal costPerPack)
            {
                decimal savingsPerDay = (cigarettesPerDay / cigarettesPerPack) * costPerPack;

                return savingsPerDay;
            }

            public static decimal CalculateSavingsPerPeriod(decimal savingsPerDay, int daysNotSmoked)
            {
                decimal savingsPerPeriod = savingsPerDay * daysNotSmoked;

                return savingsPerPeriod;
            }

            public static decimal MoneySpentOnPacks(int packsBoughtToday)
            {
                return packsBoughtToday * costPerPack; 
            }

        
    }
}

