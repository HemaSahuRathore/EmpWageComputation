namespace D4_EmpWageComputation
{   /// <summary>
    ///  UC7 : Refactor Code to write a class Method to compute Employee Wage 
    /// </summary>
    public class Program
    {   
        //Entrypoint for all console applications
         static void Main(string[] args)
         {
            ComputeEmpWage computeEmpWage = new ComputeEmpWage(); //Creating object of class ComputeEmpWage
            computeEmpWage.ComputeEmployeeWage(); //Calling ComputeEmployeeWage() method of ComputeEmpWage class to calculate wage

        }
    }
}