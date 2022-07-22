using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_EmpWageComputation
{ 
    public class EmpWageCalculation
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        public static void calEmpWage(string company, int wagePerHour, int maxNumWorkingDays, int maxHour)
        {

            int empHour = 0, empWage = 0, totalWage = 0;
            int day = 1;
            int workingHour = 0;
            Random random = new Random();
            //using while loop as we are not aware as how many iteration is required to get the desired output
            while (day <= maxNumWorkingDays && workingHour < maxHour)
            {
                int empCheck = random.Next(0, 3);  //using next() method to generate random values 0, 1 & 2

                //Using selection statement to check for full time and part time employee
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHour = 8; //Employee is present full time, assiging full time hour = 8
                        break;

                    case IS_PART_TIME:
                        empHour = 4; //Employee is present part time, assiging part time hour = 4
                        break;

                    default:
                        empHour = 0; //Employee is absent, assiging empHour = 0
                        break;
                }

                workingHour += empHour;
                empWage = empHour * wagePerHour; //Calculating Emp Wage( = Emp hour * wage per hour) for one day
                Console.WriteLine("Employee wage for day-{0} is {1}", day, empWage); //displaying Emp wage
                totalWage += empWage;  //total wage for max day or max hour
                day++; //incrementing day after every iteration and to avoid infinite while loop
            }
            Console.WriteLine("\nTotal Wage of {0} for {1} day (working hour {2}) is {3}", company, day - 1, workingHour, totalWage);
            Console.ReadLine();

    }

}
}