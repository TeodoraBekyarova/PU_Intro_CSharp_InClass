using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MusicFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Do you want to play some music?");
            string answer = Console.ReadLine();

            Console.WriteLine($"My answer is: {answer}");
            if (answer == "Yes") 
            {
                using (SoundPlayer player = new SoundPlayer(@"C: \Users\fmi\Desktop\w3\PU_Intro_CSharp_InClass\W3InClass\MusicFactory\Music"))
                {
                    Console.WriteLine("Now is playing");
                    player.PlaySync();
                    while (true)
                    {
                        Console.Write(".");
                    }
                }
            }

            else if (answer == "No")
            {
                Console.WriteLine("Go fuck yourself_!_");
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
            
        
        }
    }
}
