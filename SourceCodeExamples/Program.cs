// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Security.Cryptography;

namespace SourceCode
{
    public class Program
    {
        public static void Main()         //static Method 
        {
            // Program.EvenNumber(51);
            // Program.Add(30, 20);
            // Program p = new Program();
            // Console.WriteLine(p.Add(30, 20));
            // Console.WriteLine(p.Radius(2));
            //  Program.Radius(2);
            //Program.Name();
            //Console.Write("Enter your name :");
            //string name = Console.ReadLine();
            //Welcome(name);
            Program p = new Program();
            Console.WriteLine("Enter First Number :");
            int FN = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            int SN = int.Parse(Console.ReadLine());
            int R=  p.Addition(FN, SN);
            Console.WriteLine($"The addition of two numbers is :  {R}");

        }
        public  int Add(int FN,int SN)
        {
            return FN + SN;
        }
        public static void EvenNumber(int Target)   //static method
        {
            //Console.WriteLine("Enter the start number");
            //int start = Convert.ToInt32(Console.ReadLine());
            int start = 0;
            

            while(start <= Target)
            {

                Console.WriteLine(start);
                start = start + 2;
            }
        }
        public static void  Radius(double radius)
        {
            int r =  (int) (Math.PI * radius * radius);
            Console.WriteLine(r);
        }
        public static void Name()
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome friend {name}!");
            Console.WriteLine("Have a nice day !");
        }
        public static void Welcome(string name)
        {
            Console.WriteLine($"welcome friend {name} !");
            Console.WriteLine("Have a Nice Day !");
        }
        public int Addition(int FN,int SN)
        {
            return FN+SN;
        } 
    }
}