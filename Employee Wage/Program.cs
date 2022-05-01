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
            Random random = new Random();  // random is a method 
            int empChake = random.Next(0, 2);  // it print 0,1
            if (empChake == fulltime)
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
