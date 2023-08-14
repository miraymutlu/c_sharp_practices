using System;

namespace RecursiveAndExtensionMethods
{
    public static class StringExtensions
    {
        public static string ReverseString(this string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

    class Program
    {
        // Recursive method to calculate the factorial of a number
        static int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            // Recursive method example
            int num = 5;
            int factorial = Factorial(num);
            Console.WriteLine($"Factorial of {num} is {factorial}");

            // Extension method example
            string originalString = "Hello, world!";
            string reversedString = originalString.ReverseString();
            Console.WriteLine($"Original string: {originalString}");
            Console.WriteLine($"Reversed string: {reversedString}");

            Console.ReadLine();
        }
    }
}
