using System;
using System.Text;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
           // int smiley = 9786;
            // Console.WriteLine((char)smiley);
            
            //string firstName = Console.ReadLine();
            //string lastName = "Бончо";
            //string fullName = $"{firstName}{lastName}";
            //Console.WriteLine($"Candy for {fullName}!");
            

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\fmi\Desktop\31\PU_Intro_CSharp_InClass\W3InClass\CandyShop\Files\students1.txt");

            // Display the file contents by using a foreach loop.
            Console.WriteLine("Contents of students1.txt = ");
            foreach (string line in lines)
            {
                string[] currentElemets = line.Split(' ');
                string firstName = currentElemets[1];
                string lastName = currentElemets[3];
                string fullName = $"{firstName} {lastName}";

                int sum = 0;
                for (int i = 0; i < firstName.Length; i++)
                {
                    sum += (int)firstName[i];
                }

                // Use a tab to indent each line of the file.
                Console.WriteLine($"Candy for {fullName}=>{sum}!");
            }


        }
    }
}