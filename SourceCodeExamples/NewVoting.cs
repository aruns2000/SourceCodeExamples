using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeExamples
{
    public class NewVoting
    {
        public static void Main()
        {
            Voting();

        }
        public static void Voting()
        {
           
            int[] arr = new int[12];
            
             
            int year = 2022;
            for (int  i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter your Birth Year :");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] >= year || arr[i] <= 0)
                {
                    Console.WriteLine(0);
                }

                else if (arr[i] <= year)
                {
                    int n = arr[i] + 18;
                    if (n >= 2022)
                    {
                        Console.WriteLine(n);

                    }
                    else if (n <= 2022)
                    {
                        Console.WriteLine(2022);

                    }

                }

            }
        }
    }
}
