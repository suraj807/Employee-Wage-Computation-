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
            const int isFullTime = 1;
            const int isPartTime = 2;
             int wagePerHour = 20;
            int empWorkHour = 0;
            int empDailyWage = 0;
            Random random = new Random(); // Creating object of Random class
            int check = random.Next(0, 3); // Generating random number 0  1 or 2
            switch(check)
            {
                case isFullTime:    // Checking that employee is present for full time
                    Console.WriteLine("Employee is Present for Full Time");
                    empWorkHour = 8;
                    break;

                    case isPartTime:   // Checking that employee is present for full time
                    Console.WriteLine("Employee is Present for Part Time");
                    empWorkHour = 4;
                    break;

                    default:
                    Console.WriteLine("Employee is Absent");
                    empWorkHour = 0;
                    break;
            }
           
            empDailyWage = empWorkHour * wagePerHour; // Calculating Daily Wage of Employee
            Console.WriteLine($"\nEmployee Daily Wage : {empDailyWage}\n");
            Console.ReadLine();


        }
    }
}

 