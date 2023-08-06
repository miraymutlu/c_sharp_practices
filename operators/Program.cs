namespace operators;
class Program
{
    static void Main(string[] args)
    {
            int a = 10;
            int b = 5;

            int additionResult = a + b;     // Addition
            int subtractionResult = a - b;  // Subtraction
            int multiplicationResult = a * b;  // Multiplication
            int divisionResult = a / b;     // Division
            int moduloResult = a % b;       // Modulus (remainder of division)

            Console.WriteLine("Arithmetic Operators:");
            Console.WriteLine($"a + b = {additionResult}");
            Console.WriteLine($"a - b = {subtractionResult}");
            Console.WriteLine($"a * b = {multiplicationResult}");
            Console.WriteLine($"a / b = {divisionResult}");
            Console.WriteLine($"a % b = {moduloResult}");

            // Relational Operators
            bool isEqual = a == b;          // Equal to
            bool isNotEqual = a != b;       // Not equal to
            bool isGreater = a > b;         // Greater than
            bool isLess = a < b;            // Less than
            bool isGreaterOrEqual = a >= b; // Greater than or equal to
            bool isLessOrEqual = a <= b;    // Less than or equal to

            Console.WriteLine("\nRelational Operators:");
            Console.WriteLine($"a == b: {isEqual}");
            Console.WriteLine($"a != b: {isNotEqual}");
            Console.WriteLine($"a > b: {isGreater}");
            Console.WriteLine($"a < b: {isLess}");
            Console.WriteLine($"a >= b: {isGreaterOrEqual}");
            Console.WriteLine($"a <= b: {isLessOrEqual}");

            // Logical Operators
            bool logicalAnd = (a > 0) && (b > 0);   // Logical AND
            bool logicalOr = (a > 0) || (b > 0);    // Logical OR
            bool logicalNot = !(a > 0);             // Logical NOT

            Console.WriteLine("\nLogical Operators:");
            Console.WriteLine($"(a > 0) && (b > 0): {logicalAnd}");
            Console.WriteLine($"(a > 0) || (b > 0): {logicalOr}");
            Console.WriteLine($"!(a > 0): {logicalNot}");

            // Assignment Operators
            int x = 10;
            x += 5;     // Equivalent to x = x + 5
            x -= 3;     // Equivalent to x = x - 3
            x *= 2;     // Equivalent to x = x * 2
            x /= 4;     // Equivalent to x = x / 4
            x %= 2;     // Equivalent to x = x % 2

            Console.WriteLine("\nAssignment Operators:");
            Console.WriteLine($"x = 10; x += 5; x = {x}");

            // Increment and Decrement Operators
            int y = 5;
            int preIncrement = ++y;   // Pre-increment: y is incremented first, then the value is used.
            int postIncrement = y++;  // Post-increment: the current value of y is used, then y is incremented.

            Console.WriteLine("\nIncrement and Decrement Operators:");
            Console.WriteLine($"y = 5; ++y = {preIncrement}");
            Console.WriteLine($"y = 5; y++ = {postIncrement}");
    }
}
