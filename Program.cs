using System;

namespace BankAccount
{
    class EmployeeWage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWage COmputation");
            int employeePresent = 1;
            Random r = new Random();
            int employeeInput = r.Next(0, 2);

            if (employeePresent == employeeInput)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
            Console.ReadLine();
           
        }
    }
}
