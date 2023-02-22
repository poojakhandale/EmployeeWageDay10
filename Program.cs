// See https://aka.ms/new-console-template for more information
using EmployeeWage;

namespace Day10EmpWage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmpWageBuilder wipro = new EmpWageBuilder("wipro", 12, 3, 10);
            EmpWageBuilder tcs = new EmpWageBuilder("TATA CONSULTANCY SERVICES", 10, 4, 21);

            wipro.computeEmpWage();
            Console.WriteLine(wipro.toString());
            tcs.computeEmpWage();
            Console.WriteLine(tcs.toString());
        }
    }
}

            //Console.WriteLine("UC_10 Solution -- Check wage for multiple companies");
       
    
