using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_EmpWageComputation
{
    public class EmpWageCalculation
    {
        string company;
        int wagePerHour;
        int maxNumWorkingDays;
        int maxHour;
        int totalWage;

        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;

        //Constructor
        public EmpWageCalculation(string company, int wagePerHour, int maxNumWorkingDays, int maxHour)
        {
            this.company = company;
            this.wagePerHour = wagePerHour;
            this.maxNumWorkingDays = maxNumWorkingDays;
            this.maxHour = maxHour;
        }

        //Method to calculate Emp wage
        public void CalEmpWage()
        {

            int empHour = 0, empWage = 0;
            int day = 1;
            int workingHour = 0;
            Random random = new Random();
            //using while loop as we are not aware as how many iteration is required to get the desired output
            while (day <= maxNumWorkingDays && workingHour < maxHour)
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
                empWage = empHour * wagePerHour; //Calculating Emp Wage( = Emp hour * wage per hour) for one day
                Console.WriteLine("Employee wage for day-{0} is {1}", day, empWage); //displaying Emp wage
                totalWage += empWage;  //total wage for max day or max hour
                day++; //incrementing day after every iteration and to avoid infinite while loop
            }
            Console.WriteLine("\nTotal Wage of {0} for {1} day (working hour {2}) is {3}", company, day - 1, workingHour, totalWage);


        }
        public override string ToString()
        {
            return "\nCompany: " + this.company + "  Total wage: " + this.totalWage;
        }

    }
}