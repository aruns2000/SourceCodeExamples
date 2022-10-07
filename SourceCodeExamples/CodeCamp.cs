using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeExamples
{
    public class CodeCamp
    {


        public static void Main()
        {
            //Console.WriteLine(cube(6)); 
            //SayHi("Arun");
            //SayHi("kiran");
            //SayHi("Abhi");
            //int[] numbers = { 8, 2, 6, 4, 9, 3, };
            //numbers[5] = 100;
            //string[] friends = new string[10];
            //friends[0] = "Kiran";
            //friends[1] = "Abhi";
            //friends[2] = "Vinay";
            //friends[2] = "Vishwa";
            //Console.WriteLine(friends[2]);
            //Console.WriteLine(numbers[5]);
            //string name = Console.ReadLine();
            //int n = Convert.ToInt32(Console.ReadLine());
            //double nu = Convert.ToDouble(Console.ReadLine());
            //int num = Convert.ToInt32("5");
            //Console.WriteLine(num + 6);
            // Console.WriteLine("Hello world");


            //decimal V = (decimal)(10.233 * 2.355);
            //Console.WriteLine(V);   
            //string phrase = "Giraffe Academy";

            // Console.WriteLine(phrase[8]);

            //  Console.ReadLine();
            //
            // 
            //Console.WriteLine("Enter the two numbers");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("The Minimum Number is :"+ Math.Min(a,b));
            //Console.WriteLine("The MAximum Number is :" +Math.Max(a,b));
            //Console.WriteLine(Math.Round(25.359641651));

            bool isTall = true;
            bool isMale = true;


            if (isTall && isMale)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isTall && !isMale)
            {
                Console.WriteLine("You are tall but not male");
            }
            else if (!isTall && isMale)
            {
                Console.WriteLine("Your are not a tal");
            }

            //public static void SayHi(string name)
            //{
            //    Console.WriteLine("Hello " + name);
            //}
            //static int cube(int num)
            //{
            //    int result = num * num * num;
            //    return result;
            //}

        }
    }
}
