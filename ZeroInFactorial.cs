using System;
namespace ZeroInFactorial
{
    class ZeroInFactorial
    {
        static void Main(string[] args)
        { 
            Console.Write("Please Enter a Number: ");
            var number = Int32.Parse(Console.ReadLine());
            int zero = 0;
            var factorial=Factorial(number);
            var noOfZero = CountZero(factorial, ref zero);
            Console.Write("The Factorial is {0} and it has ", factorial);
            Console.WriteLine("{0} zeroes.", zero);
        }
        public static long Factorial(int number)
        {
            long factorial = number;
            for (int i = number - 1; i > 0; i--)
                factorial *= i;
            return factorial;
        }
        public static int CountZero(long factorial,ref int zero)
        {
            do
            {
                factorial /= 10;
                zero++;
            } while (factorial % 10 == 0);
            return zero;
        }
    }
}