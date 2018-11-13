using System;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = 30;
            int saving = 2; //lv
            int throwAwayForFalseVodka = 5; //lv
            int monthsInYear = 12;
            double result = 0;


            try
            {
                int tankPrice = int.Parse(Console.ReadLine());
                int partyDays = int.Parse(Console.ReadLine());

                int daysWithoutVodka = days - partyDays;
                int totalMonthSavings = daysWithoutVodka * saving;
                int netSaving = totalMonthSavings - (throwAwayForFalseVodka * partyDays);

                double monthsForSaving4Tank = tankPrice / netSaving;
                result = monthsForSaving4Tank / monthsInYear;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine("Please,try again later!");
            }



            //int tank = int.Parse(Console.ReadLine());
            //int partyDays = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Total months for the tank: {result} ");

            //Console.WriteLine($"{(int)result} years");

            if (result < 0)
                Console.WriteLine("Never!");
            else
            {
                result = Math.Round(result, 1, MidpointRounding.AwayFromZero);
                string months = result.ToString().Split('.')[1];
                Console.WriteLine($"{(int)result} years and {months} months");
            }



        }
    }
}
