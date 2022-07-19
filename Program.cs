namespace D4_EmpWageComputation
{   /// <summary>
    ///  UC3: Add Part time Employee and Wage (Assuming Full time hour = 8 and Part time hour = 4)
    /// </summary>
    public class Program
    {   //Entrypoint for all console applications
        static void Main(string[] args)
        {
            //Constant Variables
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int WAGE_PER_HOUR = 20;

            //Local Variables
            int empHour = 0; ;
            int empWage;

            //Generating Random numbers using random class 
            Random random = new Random();  //creating instance of random class
            int empCheck = random.Next(0, 3);  //using next() method to generate random values 0, 1 & 2

            //Using selection statement to check for full time and part time employee
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Full time Employee is Present");
                empHour = 8; //Full time employee is present assiging full time hour = 8
            }
            else if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Part time Employee is Present");
                empHour = 4; //Part time employee is present, assiging part time hour = 4
            }
            else
                Console.WriteLine("Employee is Absent"); //not assigning empHour = 0 as by default value is 0

            empWage = empHour * WAGE_PER_HOUR; //Calculating Emp Wage( = Emp hour * wage per hour)
            Console.WriteLine("Employee wage is {0}", empWage); //displaying Emp wage
            Console.ReadLine();

        }
    }
}