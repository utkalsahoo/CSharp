using System;
namespace CompareRealNumber
{
    class CompareTwoRealNumber
    {
        static void Main(string[] args)
        {
            var number1 = 11.778788779f;
            var number2 = 11.778788778f;
            Console.WriteLine(Accuracy(number1,number2));
        }
        public static bool Accuracy(float number1, float number2)
        {
            bool equal = Math.Abs(number1 - number2) < 0.000001;
            return equal;
        }
    }
}
