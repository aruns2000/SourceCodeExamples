using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeExamples
{
    public abstract class Customer
    {
        public abstract void Print();
    }
   

    public class pg : Customer
    {
        public static void Main()
        {
          Customer customer = new pg();
            customer.Print();
        }

        public override void Print()
        {
            Console.WriteLine( "Hello ");
        }
    }
}
