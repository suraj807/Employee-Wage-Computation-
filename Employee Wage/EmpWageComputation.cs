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
            EmpWageBuilder BridgeLabz = new EmpWageBuilder("Bridgelabz", 20, 20, 100);
            EmpWageBuilder TCS = new EmpWageBuilder("TCS", 40, 25, 100);
            BridgeLabz.ComputeWage();
            TCS.ComputeWage();
            Console.ReadLine();
        }
    }
}
