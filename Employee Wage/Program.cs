using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************Welcome to EmployeeWage Computation*******************\n");
            int fulltime = 1;  
            Random random = new Random();   // Creating object of Random class
            int empChake = random.Next(0, 2);  //  Generating random number 0 or 1
            if (empChake == fulltime)  //Checking that employee is present or not
            {
                Console.WriteLine ("Employee is present"); // print 1
            }
            else
            {
                Console.WriteLine("Employee is absent");    // print 0
            }


        }
    }
}
