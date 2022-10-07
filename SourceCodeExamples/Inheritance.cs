using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeExamples
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public void PrintFullName()
        {
            Console.WriteLine(FirstName +" "+ LastName );

        }

    }
    public class FullTimeEmployee:Employee
    {
        public float YearlySalary;

    }
    public class PartTimeEmployee : Employee
    {
        public float HourlySalary;

    }


    public class Inheritance
    {
        public static void Main()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Arun";
            FTE.LastName = "s";
            FTE.YearlySalary = 4000000;
            FTE.PrintFullName();    
            
            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Kiran";
            PTE.LastName = "N";
            PTE.HourlySalary = 500;
            PTE.PrintFullName();
        }
    }
}
