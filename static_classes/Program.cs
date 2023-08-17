using System;

// Static class with static members
static class MathUtility
{
    // Static field
    public static double Pi = 3.14159;

    // Static method
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // Static property
    public static int MultiplyByTwo { get; set; }

    // Static constructor (optional)
    static MathUtility()
    {
        MultiplyByTwo = 2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Accessing static field
        Console.WriteLine("Pi: " + MathUtility.Pi);

        // Accessing static method
        int sum = MathUtility.Add(5, 7);
        Console.WriteLine("Sum: " + sum);

        // Accessing static property
        int result = 10 * MathUtility.MultiplyByTwo;
        Console.WriteLine("Result: " + result);
    }
}
