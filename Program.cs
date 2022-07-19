namespace D4_EmpWageComputation
{   /// <summary>
    ///  UC5 : Calculating Wages for a Month assuming 20 Working days
    /// </summary>
    public class Program
    {   //Entrypoint for all console applications

        static void Main(string[] args)
        {
            //Constant Variables
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int WAGE_PER_HOUR = 20;
            const int NUM_WORKING_DAYS = 20;

            //Local Variables
            int empHour = 0;
            int empWage = 0;
            int totalWage = 0;
            int day;

            //Generating Random numbers using random class 
            Random random = new Random();  //creating instance of random class

            for (day = 1; day <= NUM_WORKING_DAYS; day++)
            {
                int empCheck = random.Next(0, 3);  //using next() method to generate random values 0, 1 & 2

                //Using selection statement to check for full time and part time employee
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        Console.WriteLine("\nFull time Employee is Present");
                        empHour = 8; //Full time employee is present, assiging full time hour = 8
                        break;

                    case IS_PART_TIME:
                        Console.WriteLine("\nPart time Employee is Present");
                        empHour = 4; //Part time employee is present, assiging part time hour = 4
                        break;

                    default:
                        Console.WriteLine("\nEmployee is Absent");
                        empHour = 0;
                        break;
                }

                empWage = empHour * WAGE_PER_HOUR; //Calculating Emp Wage( = Emp hour * wage per hour)
                Console.WriteLine("Employee wage for day-{0} is {1}", day, empWage); //displaying Emp wage
                totalWage += empWage;  //total wage for the month
            }
            Console.WriteLine("\nTotal Wage for the month ({0} Working days) is : {1} ", day - 1, totalWage);
            Console.ReadLine();
        }
    }
}