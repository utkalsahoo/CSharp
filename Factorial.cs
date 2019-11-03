using System;
namespace FactroialOfNDevidedByK
{
    class Factorial
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the second number:");
            int number2 = int.Parse(Console.ReadLine());
            if (number2 <= 1 || number2 > number1 || number1 <= 1 || number1 >= 100 || number2 >= 100)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                  var result=Factorials(number1, number2);
                  Console.WriteLine(result);
            }
        }
        public static long Factorials(int number1, int number2)
        {
            int factorialOfN = 1;
            int factorialOfK = 1;
            for (int i = 1; i <= number1; i++)
            {
                factorialOfN *= i;
                if (i <= number2)
                {
                    factorialOfK *= i;
                }
            }
            return(factorialOfN / factorialOfK);
        }
    }
}