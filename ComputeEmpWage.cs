using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_EmpWageComputation
{
    internal class ComputeEmpWage
    {
        public void ComputeEmployeeWage()
        {
            //Constant Variables
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int WAGE_PER_HOUR = 20;
            const int MAX_NUM_WORKING_DAYS = 20;
            const int MAX_HOUR = 100;


            //Local Variables
            int empHour = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;
            int workingHour = 0;

            //Generating Random numbers using random class 
            Random random = new Random();  //creating instance of random class
            //using while loop as we are not aware as how many iteration is required to get the desired output
            while (day <= MAX_NUM_WORKING_DAYS && workingHour < MAX_HOUR)
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
                empWage = empHour * WAGE_PER_HOUR; //Calculating Emp Wage( = Emp hour * wage per hour) for one day
                Console.WriteLine("Employee wage for day-{0} is {1}", day, empWage); //displaying Emp wage
                totalWage += empWage;  
                day++; 
            }

            Console.WriteLine("\nTotal Wage for {0} day (working hour {1}) is {2}", day - 1, workingHour, totalWage);
            Console.ReadLine();
        }
    }
}
