using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeExamples
{
    public class NewEmployee
    {
       public string FirstName;
        public string LastName;
        public string Email;
        public  void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);

        }
    }
    public class FullTime : NewEmployee
    {
        public float YearlySalary;

    }
    public class PartTime : NewEmployee
    {
        public float HourlySalary;
    }

    public  class InheritNew
    {
        public static void Main()
        {
            FullTime n = new FullTime();
            n.FirstName = "Mr";
            n.LastName = "Nag";
            n.YearlySalary = 100000;
            n.PrintFullName();
            
           
        }
    }
}
