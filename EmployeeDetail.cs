using System;
namespace EmployeeDetails
{
    class EmployeeDetail
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Your Age: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Please enter your gender(m 0r f): ");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please Enter your unique Employee Number: ");
            int employeeId = Convert.ToInt32(Console.ReadLine());
        }
    }
}
