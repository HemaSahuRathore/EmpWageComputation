namespace D4_EmpWageComputation
{
    /// <summary>
    ///  UC2: Calculate Daily Employee Wage
    /// </summary>
    public class Program
    {
        //Entrypoint for all console applications
        static void Main(string[] args)
        {
            //Constant Variables
            const int EMP_PRESENT = 1;
            const int WAGE_PER_HOUR = 20;

            //Local Variables
            int empHour = 0; ;
            int empWage;

            //Generating Random numbers using random class 
            Random random = new Random();  //creating instance of random class
            int IsPresent = random.Next(0, 2);  //using next() to generate random values 0 & 1

            //Using selection statement to check and display whether employee is present or absent
            if (IsPresent == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present");
                empHour = 8; //if Employee is present assiging full day hour = 8
            }
            else
                Console.WriteLine("Employee is Absent"); //not assigning empHour = 0 as by default value is 0

            empWage = empHour * WAGE_PER_HOUR; //Calculating Emp Wage( = Emp hour * wage per hour)
            Console.WriteLine("Employee wage is {0}", empWage); //displaying Emp wage
            Console.ReadLine();

        }
    }
}