namespace method_overloading;
class Program
{
    // Method overloading example
    static int Add(int a, int b)
    {
        return a + b;
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    // Method with ref parameter
    static void MultiplyByTwo(ref int number)
    {
        number *= 2;
    }

    // Method with out parameter
    static bool TryDivide(int dividend, int divisor, out double result)
    {
        if (divisor != 0)
        {
            result = (double)dividend / divisor;
            return true;
        }
        else
        {
            result = 0;
            return false;
        }
    }

    static void Main(string[] args)
    {
        // Method overloading
        int intSum = Add(5, 3);
        double doubleSum = Add(3.5, 2.7);

        Console.WriteLine("Int Sum: " + intSum);
        Console.WriteLine("Double Sum: " + doubleSum);

        // Using ref parameter
        int number = 10;
        Console.WriteLine("Original number: " + number);
        MultiplyByTwo(ref number);
        Console.WriteLine("Number after multiplication: " + number);

        // Using out parameter
        int dividend = 10;
        int divisor = 3;
        double divisionResult;

        if (TryDivide(dividend, divisor, out divisionResult))
        {
            Console.WriteLine($"{dividend} / {divisor} = {divisionResult}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }

        Console.ReadLine();
}
}
