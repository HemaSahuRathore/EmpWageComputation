namespace D4_EmpWageComputation
{
    /// <summary>
    /// UC1: Check Employee is Present or Absent
    /// </summary>

    public class Program
    {
        //Entrypoint for all console applications
        static void Main(string[] args)
        {
            //Constant Variable
            const int EMP_PRESENT = 1;

            //Generating Random numbers using random class 
            Random random = new Random();  //creating instance of random class
            int IsPresent = random.Next(0, 2);  //using next() to generate random values in range (0,1)

            //Using selection statement to check and display whether employee is present or absent
            if (IsPresent == EMP_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
            Console.ReadLine();

        }
    }
}