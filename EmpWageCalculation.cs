using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_EmpWageComputation
{
    public class EmpWageCalculation
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        List<CompanyEmpWage> companiesList; //Declaring List of CompanyEmpWage type
        
        public EmpWageCalculation()
        {
            companiesList = new List<CompanyEmpWage>(); //Creating companiesList of CompanyEmpWage type
        }

        public void AddCompanyWage(string company, int wagePerHour, int maxNumWorkingDays, int maxHour)
        {
            CompanyEmpWage companyEmpWageObj = new CompanyEmpWage(company, wagePerHour, maxNumWorkingDays, maxHour);
            companiesList.Add(companyEmpWageObj);
        }

        public void ComputeEmpWage()
        {
            for(int i = 0; i < companiesList.Count; i++)
            {
                int totalWage = ComputeEmpWage(companiesList[i]);
                companiesList[i].SetTotalWage(totalWage);
                Console.WriteLine("Companies Details : " + companiesList[i]);
               
            }
        }

        public int ComputeEmpWage(CompanyEmpWage CompanyEmpWage)
        {
            int empHour = 0, empWage = 0; int totalWage = 0;
            int day = 1;
            int workingHour = 0;

            Random random = new Random();
            
            while (day <= CompanyEmpWage.maxNumWorkingDays && workingHour < CompanyEmpWage.maxHour)
            {
                int empCheck = random.Next(0, 3);
                 
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                            empHour = 8;
                            break;

                    case IS_PART_TIME:
                            empHour = 4;
                            break;

                    default:
                            empHour = 0;
                            break;
                }

                workingHour += empHour;
                empWage = empHour * CompanyEmpWage.wagePerHour; 
                Console.WriteLine("Employee wage for day-{0} is {1}", day, empWage); 
                totalWage = totalWage + empWage;  
                day++; 

            }

            return totalWage;
        }
          
    }
}