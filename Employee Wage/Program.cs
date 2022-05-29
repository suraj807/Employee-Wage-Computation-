using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEmpWageComputation
{
    internal class EmpWageComputation
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        static void Main(string[] args)
        {
<<<<<<< Updated upstream
            Console.WriteLine("Welcome to Employee Wage Compuatation Program\n");
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int WAGE_PER_HOUR = 20;
            const int MAX_WORKING_DAYS = 20;
            int totalMonthWage = 0;
            int empWorkHour = 0;
            int empDailyWage = 0;
            Random random = new Random(); // Creating object of Random class
            for (int day = 1; day <= MAX_WORKING_DAYS; day++) //For loop is used for calculating daily wages of Whole Month days and Total wage of Month
            {
                int check = random.Next(0, 3); // Generating random number 0 , 1 , 2
                // Checking that employee is present for full time ,part time or not using switch
                switch (check)
                {
                    case IS_FULL_TIME:
=======
            Console.WriteLine("*****************Welcome to EmployeeWage Computation*******************\n");
           // const int isFullTime = 1;
           // const int isPartTime = 2;
             //int wagePerHour = 20;
           // int numofworkdays = 20;
           // int empWorkHour = 0;
            //int empDailyWage = 0;
           // int totalempwage = 0;
           int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while(totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)

          //  for (int day = 0; day < numofworkdays; day++) //For loop is used for calculating daily wages of Whole Month days and Total wage of Month
            {
                totalWorkingDays++;
                Random random = new Random(); // Creating object of Random class
                int check = random.Next(0, 3); // Generating random number 0  1 or 2
                switch (check)
                {
                    case IS_FULL_TIME:    // Checking that employee is present for full time
>>>>>>> Stashed changes
                        Console.WriteLine("Employee is Present for Full Time");
                        empHrs = 8;
                        break;

<<<<<<< Updated upstream
                    case IS_PART_TIME:
=======
                    case IS_PART_TIME:   // Checking that employee is present for full time
>>>>>>> Stashed changes
                        Console.WriteLine("Employee is Present for Part Time");
                        empHrs = 4;
                        break;

                    default:
                        Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;
                }
<<<<<<< Updated upstream
                empDailyWage = empWorkHour * WAGE_PER_HOUR; // Calculating Daily Wage of Employee
                Console.WriteLine($"Employee Daily Wage for Day {day} : {empDailyWage}\n");
                totalMonthWage += empDailyWage; // Adding Daily Wage to Total Wage
            }
            Console.WriteLine($"\nEmployee Total Month Wage : {totalMonthWage}\n");
=======

                //empDailyWage = empWorkHour * wagePerHour; // Calculating Daily Wage of Employee
                // += empDailyWage; // Adding Daily Wage to Total Wage
                //Console.WriteLine($"\nEmployee Daily Wage : {empDailyWage}\n");

                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs :"+ empHrs);
            }
            //  Console.WriteLine("total  emp Wage :" +totalempwage);
            int totalEmpWage = totalEmpHrs + EMP_RATE_PER_HOUR;
            Console.WriteLine(" Total Emp wage : "+ totalEmpWage);

>>>>>>> Stashed changes
            Console.ReadLine();
                                                                                                                                                                                                                                                                                            }
    }
}