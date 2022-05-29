using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    internal class Program
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        public static void ComputeWage(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours) //Creating a class method for Wage Computation with parameters
        {
            int totalMonthWage = 0, empWorkHour = 0, empDailyWage = 0, empTotalHour = 0, empTotalWorkDays = 0;
            Random random = new Random(); // Creating object of Random class
            while (empTotalHour <= maxWorkingHours && empTotalWorkDays <= maxWorkingDays) // Checking that Employee total work hours should be less than or equal to 100 or Employee working days should be Less or equl to 20 
            {
                int check = random.Next(0, 3); // Generating random number 0 , 1 , 2
                // Checking that employee is present for full time ,part time or not using switch
                switch (check)
                {
                    case IS_FULL_TIME:
                        // Console.WriteLine("Employee is Present for Full Time");
                        empWorkHour = 8;
                        break;

                    case IS_PART_TIME:
                        // Console.WriteLine("Employee is Present for Part Time");
                        empWorkHour = 4;
                        break;
                    default:
                        // Console.WriteLine("Employee is Absent");
                        empWorkHour = 0;
                        break;
                }
                empDailyWage = empWorkHour * wagePerHour; // Calculating Daily Wage of Employee
                                                          // Console.WriteLine($"Employee Daily Wage for Day {empTotalWorkDays} : {empDailyWage}\n");
                totalMonthWage += empDailyWage; // Adding Daily Wage to Total Wage
                empTotalWorkDays++;
                empTotalHour += empWorkHour;
            }
            if (empTotalHour > maxWorkingHours) //Checking that hours are more than 100 or not
            {
                int a = empTotalHour - maxWorkingHours;
                empTotalHour -= a;
                int wage = a * wagePerHour; // Calculate exatra hours wage
                totalMonthWage -= wage; // Minus extra hours wage from emp total wage
            }
            if (empTotalWorkDays > maxWorkingDays)
            {
                empTotalWorkDays -= 1;
            }
            Console.WriteLine("\n\nCompany Name : " + companyName);
            Console.WriteLine($"\nEmployee total working days   : {empTotalWorkDays}");
            Console.WriteLine($"Employee total working hours  : {empTotalHour}\n");
            Console.WriteLine($"Employee Total Month Wage : {totalMonthWage}\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Compuatation Program\n");
            ComputeWage("Bridgelabz", 20, 20, 100);
            ComputeWage("Infosys", 40, 20, 100);
            Console.ReadLine();
        }
    }
}

 