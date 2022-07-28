namespace D4_EmpWageComputation
{   /// <summary>
    ///  UC12: Refactor to have list of multiple companies to manage Employee Wage
    /// </summary>
    public class Program
    {   //Entrypoint for all console applications
        static void Main(string[] args)
        {

           EmpWageCalculation empWageCalculation1 = new EmpWageCalculation();
           empWageCalculation1.AddCompanyWage("HCL", 20, 5, 50);
           empWageCalculation1.AddCompanyWage("Wipro", 25, 10, 40);
           empWageCalculation1.ComputeEmpWage();
          
        }
    }
}