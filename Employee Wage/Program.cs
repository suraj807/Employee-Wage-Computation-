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
             int isPresent = 1;
             int wagePerHour = 20;
             int empWorkHour = 0;
             int empDailyWage = 0;
             Random random = new Random(); // Creating object of Random class
            int check = random.Next(0, 2); // Generating random number 0 or 1
            if (check == isPresent) // Checking that employee is present or not
            {
                Console.WriteLine("Employee is Present");
                empWorkHour = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empWorkHour = 0;
            }
            empDailyWage = empWorkHour * wagePerHour; // Calculating Daily Wage of Employee
            Console.WriteLine($"\nEmployee Daily Wage : {empDailyWage}\n");
            Console.ReadLine();


        }
    }
}
