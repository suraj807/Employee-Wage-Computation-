using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    internal interface IComputeWage
    {
        void AddCompany(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours);
        void IterateOverListOfCompany();
        //  int ComputeWage(CompanyEmpWage obj);

    }
}
