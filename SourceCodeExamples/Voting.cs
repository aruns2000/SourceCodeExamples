using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeExamples
{
    public class Voting
    {
        public static void Main()
        {
            Eligiblity();
        }
        public static void Eligiblity()
        {
            Console.Write("Enter your Birth Year :");
            int year = int.Parse(Console.ReadLine());

            int age = 2022 - year;

            if (year >= 2022)
            {
                int Sol = year + 18;
                Console.WriteLine($"Your eligible for {Sol}");
                
            }
            else if (age >= 18)
            {
                Console.WriteLine($"Your age is :{age}");
                Console.WriteLine("Your Eligible for voting this year ,2022");
            }
            else if (age < 18)
            {
                int Sol = year + 18;

                Console.WriteLine($"Your age is :{age}");
                Console.WriteLine("Your not eligible for voting this year ,2022");

                Console.WriteLine($"Your eligible for {Sol}");
            }
            
        }
        
    }
}
