namespace c_sharp_practices;
class Program
{
    static void Main(string[] args)
    {
        // Integer Types
            int integerValue = 10;                 // 32-bit signed integer
            uint unsignedIntegerValue = 100;       // 32-bit unsigned integer
            short shortValue = 30000;             // 16-bit signed integer
            ushort unsignedShortValue = 60000;    // 16-bit unsigned integer
            long longValue = 1234567890L;         // 64-bit signed integer
            ulong unsignedLongValue = 9876543210UL; // 64-bit unsigned integer

            // Floating-Point Types
            float floatValue = 3.14f;             // 32-bit floating-point number
            double doubleValue = 3.14159;         // 64-bit double-precision floating-point number
            decimal decimalValue = 3.141592653589793238M; // 128-bit decimal number

            // Character Type
            char characterValue = 'A';            // 16-bit Unicode character

            // Boolean Type
            bool booleanValue = true;             // Represents true or false

            // String Type
            string stringValue = "Hello, C#";     // Sequence of characters

            // Object Type
            object objValue = 42;                 // Can hold any type of value

            // Dynamic Type
            dynamic dynamicValue = "I'm dynamic"; // Type is resolved at runtime

            Console.WriteLine("Integer Types:");
            Console.WriteLine($"int: {integerValue}");
            Console.WriteLine($"uint: {unsignedIntegerValue}");
            Console.WriteLine($"short: {shortValue}");
            Console.WriteLine($"ushort: {unsignedShortValue}");
            Console.WriteLine($"long: {longValue}");
            Console.WriteLine($"ulong: {unsignedLongValue}");

            Console.WriteLine("\nFloating-Point Types:");
            Console.WriteLine($"float: {floatValue}");
            Console.WriteLine($"double: {doubleValue}");
            Console.WriteLine($"decimal: {decimalValue}");

            Console.WriteLine("\nCharacter Type:");
            Console.WriteLine($"char: {characterValue}");

            Console.WriteLine("\nBoolean Type:");
            Console.WriteLine($"bool: {booleanValue}");

            Console.WriteLine("\nString Type:");
            Console.WriteLine($"string: {stringValue}");

            Console.WriteLine("\nObject Type:");
            Console.WriteLine($"object: {objValue}");

            Console.WriteLine("\nDynamic Type:");
            Console.WriteLine($"dynamic: {dynamicValue}");
    }
}
