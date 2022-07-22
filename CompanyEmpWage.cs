using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_EmpWageComputation
{   
    public class CompanyEmpWage
    {
        public string company;
        public int wagePerHour, maxNumWorkingDays, maxHour, totalWage;
        public CompanyEmpWage(string company, int wagePerHour, int maxNumWorkingDays, int maxHour)
        {
            this.company = company;
            this.wagePerHour = wagePerHour;
            this.maxNumWorkingDays = maxNumWorkingDays;
            this.maxHour = maxHour;
        }

        public void SetTotalWage(int totalWage)
        {
            this.totalWage = totalWage;
        }

        public override string ToString()
        {
            return "\nCompany: " + this.company + "  Total Wage: " + this.totalWage;
        }

    }
}
