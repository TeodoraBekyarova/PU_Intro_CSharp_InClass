using System;

namespace week6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Which bus is arrived?");
                int busNumber = int.Parse(Console.ReadLine());

                switch (busNumber)
                {
                    case "99":
                        Console.WriteLine();
                        break;
                    case "44":
                        Console.WriteLine();
                        break;
                    case "20":
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Fuck");
                        break;
                }

                /*
                if (busNumber == 99)
                {
                    Console.WriteLine("I will take it:");
                }
                else if (busNumber == 44)
                {
                    Console.WriteLine("Okey, this bus will stop 5 mins before your home.");
                 else if (busNumber == 20)
                    {
                        Console.WriteLine("Okey, this bus will stop 15 mins before your home.");
                    }
                }
                else
                {
                    Console.WriteLine("I will wait another");
                }
                catch (Exception ex)
               {
                Console.WriteLine($"{ex.Message});
                }
            }
                 */
            }
    }

}

