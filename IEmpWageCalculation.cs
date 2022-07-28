using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_EmpWageComputation
{
    public interface IEmpWageCalculation
    {
        public void AddCompanyWage(string company, int wagePerHour, int maxNumWorkingDays, int maxHour);

        public void ComputeEmpWage();

        public int TotalWageBasedOnCompany(string companyName);
    }
}
