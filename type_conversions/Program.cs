namespace type_conversions;
class Program
{
    static void Main(string[] args)
    {
            // Implicit Conversion
            int intValue = 42;
            double doubleValue = intValue; // Implicit conversion from int to double

            Console.WriteLine("Implicit Conversion:");
            Console.WriteLine($"int value: {intValue}");
            Console.WriteLine($"double value: {doubleValue}");

            // Explicit Conversion (Casting)
            double doubleValue2 = 3.14;
            int intValue2 = (int)doubleValue2; // Explicit conversion (casting) from double to int

            Console.WriteLine("\nExplicit Conversion (Casting):");
            Console.WriteLine($"double value: {doubleValue2}");
            Console.WriteLine($"int value: {intValue2}");

            // Parsing
            string numericString = "12345";
            int parsedInt = int.Parse(numericString);

            Console.WriteLine("\nParsing:");
            Console.WriteLine($"Numeric string: {numericString}");
            Console.WriteLine($"Parsed int value: {parsedInt}");

            // TryParse
            string nonNumericString = "Hello";
            int tryParsedInt;
            bool tryParseResult = int.TryParse(nonNumericString, out tryParsedInt);

            Console.WriteLine("\nTryParse:");
            Console.WriteLine($"Non-numeric string: {nonNumericString}");
            if (tryParseResult)
            {
                Console.WriteLine($"TryParsed int value: {tryParsedInt}");
            }
            else
            {
                Console.WriteLine("TryParse failed. The input is not a valid integer.");
            }

            // Convert class
            int intValue3 = 100;
            string stringValue = Convert.ToString(intValue3); // Convert int to string

            Console.WriteLine("\nConvert class:");
            Console.WriteLine($"int value: {intValue3}");
            Console.WriteLine($"Converted string value: {stringValue}");
    }
}
