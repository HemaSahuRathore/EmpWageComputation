namespace D4_EmpWageComputation
{   /// <summary>
    ///  UC9: Compute employee Wage and save total wage by company
    /// </summary>
    public class Program
    {   //Entrypoint for all console applications
        static void Main(string[] args)
        {
            EmpWageCalculation empWageObj1 = new EmpWageCalculation("HCL", 100, 21, 270);
            empWageObj1.CalEmpWage(); //saved total wage by HCL in empWageObj1
            Console.WriteLine(empWageObj1.ToString());

            EmpWageCalculation empWageObj2 = new EmpWageCalculation("Wipro", 80, 25, 280);
            empWageObj2.CalEmpWage(); //saved total wage by Wipro in empWageObj2
            Console.WriteLine(empWageObj2.ToString());

        }
    }
}