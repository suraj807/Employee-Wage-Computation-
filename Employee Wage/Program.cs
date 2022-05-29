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
            Console.WriteLine("Welcome to Employee Wage Compuatation Program\n");
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int WAGE_PER_HOUR = 20;
            const int MAX_WORKING_DAYS = 20;
            const int MAX_WORK_HOURS = 100;
            int totalMonthWage = 0, empWorkHour = 0, empDailyWage = 0, empTotalHour = 0, empTotalWorkDays = 0;
            Random random = new Random(); // Creating object of Random class
            while (empTotalHour <= MAX_WORK_HOURS && empTotalWorkDays <= MAX_WORKING_DAYS) // Checking that Employee total work hours should be less than or equal to 100 or Employee working days should be Less or equl to 20 
            {
                int check = random.Next(0, 3); // Generating random number 0 , 1 , 2
                // Checking that employee is present for full time ,part time or not using switch
                switch (check)
                {
                    case IS_FULL_TIME:
                        Console.WriteLine("Employee is Present for Full Time");
                        empWorkHour = 8;
                        break;

                    case IS_PART_TIME:
                        Console.WriteLine("Employee is Present for Part Time");
                        empWorkHour = 4;
                        break;

                    default:
                        Console.WriteLine("Employee is Absent");
                        empWorkHour = 0;
                        break;
                }
                empDailyWage = empWorkHour * WAGE_PER_HOUR; // Calculating Daily Wage of Employee
                Console.WriteLine($"Employee Daily Wage for Day {empTotalWorkDays} : {empDailyWage}\n");
                totalMonthWage += empDailyWage; // Adding Daily Wage to Total Wage
                empTotalWorkDays++;
                empTotalHour += empWorkHour;

                if (empTotalHour > MAX_WORK_HOURS) //Checking that hours are more than 100 or not
                {
                    int a = empTotalHour - MAX_WORK_HOURS;
                    empTotalHour -= a;
                    int wage = a * WAGE_PER_HOUR; // Calculate exatra hours wage
                    totalMonthWage -= wage; // Minus extra hours wage from emp total wage
                }
                if (empTotalWorkDays > MAX_WORKING_DAYS)
                {
                    empTotalWorkDays -= 1;
                }



                Console.WriteLine($"\nEmployee total working days  : {empTotalWorkDays}");
                Console.WriteLine($"Employee total working hours  : {empTotalHour}\n");
                Console.WriteLine($"\nEmployee Total Month Wage : {totalMonthWage}\n");
                Console.ReadLine();
            }
        }
    }
}

 