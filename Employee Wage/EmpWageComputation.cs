using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    internal class EmpWageComputation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Compuatation Program\n");
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.AddCompany("Bridgelabz", 20, 20, 100);
            empWageBuilder.AddCompany("TCS", 40, 25, 100);
            empWageBuilder.IterateOverListOfCompany();
            Console.ReadLine();
        }
    }
}
