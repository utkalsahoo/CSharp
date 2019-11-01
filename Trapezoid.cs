using System;

namespace TrapezoidArea
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the value of a:");
            var a = Convert.T Console.ReadLine();
            Console.Write("Enter the value of b:");
            var b = Console.ReadLine();
            Console.WriteLine("Enter the value of h:");
            var h = Console.ReadLine();

        }
        public static double AreaOfTrapezoid(float a,float b,float h)
        {
            var Area = (a + b) / 2 * h;
            return Area;
        }
    }
}
