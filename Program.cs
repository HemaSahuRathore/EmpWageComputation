namespace D4_EmpWageComputation
{   /// <summary>
    ///  UC8: Compute Employee wage for multiple company using procedural way using class method
    /// </summary>
    public class Program
    {   //Entrypoint for all console applications
        static void Main(string[] args)
        {
            EmpWageCalculation.calEmpWage("HCL", 100, 21, 270);
            EmpWageCalculation.calEmpWage("Wipro", 80, 25, 280);

        }
    }
}