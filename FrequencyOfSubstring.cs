using System;
namespace FrequencyOfSubstring
{
    class FrequencyOfSubstring
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");
            var string1 = Console.ReadLine();
            Console.WriteLine("Enter the substring:");
            var subString = Console.ReadLine();
            Console.WriteLine(SubstringFrequency(string1, subString));
        }
        public static int SubstringFrequency(string string1, string subString)
        {
            var stringLength = string1.Length;
            var subStringLength = subString.Length;
            var count = 0;
            for (var i = 0; i < stringLength; i++)
            {
                int j;
                for (j = 0; j < subStringLength; j++)
                {
                    if (string1[i + j] != subString[j])
                        break;
                }
                if (j == subStringLength)
                {
                    count++;
                    j = 0;
                }
            }
            return count;
        }
    }
}