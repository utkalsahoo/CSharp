using System;

namespace ReverseString
{
    class StringReverse
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            var string1= Console.ReadLine();
            Console.WriteLine(Reverse_String(string1));
        }
        public static string Reverse_String(string string1)
        {
            var reversedString = "";
            for (var i = string1.Length - 1; i >= 0; i--)
                reversedString = reversedString + string1[i];
            return reversedString;
        }
    }
}
