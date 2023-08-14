namespace string_methods;
class Program
{
    static void Main(string[] args)
    {
        string text = "   Hello, world!   ";

        // Length: Returns the number of characters in the string
        int length = text.Length;
        Console.WriteLine($"Length: {length}");

        // ToUpper and ToLower: Converts the string to uppercase and lowercase
        string upper = text.ToUpper();
        string lower = text.ToLower();
        Console.WriteLine($"ToUpper: {upper}");
        Console.WriteLine($"ToLower: {lower}");

        // Substring: Returns a substring starting at a specified index with a specified length
        string substring = text.Substring(7, 5);
        Console.WriteLine($"Substring: {substring}");

        // IndexOf and LastIndexOf: Returns the index of the first or last occurrence of a specified substring
        int firstIndex = text.IndexOf("world");
        int lastIndex = text.LastIndexOf("l");
        Console.WriteLine($"IndexOf 'world': {firstIndex}");
        Console.WriteLine($"LastIndexOf 'l': {lastIndex}");

        // Replace: Replaces occurrences of a specified substring with another substring
        string replaced = text.Replace("world", "universe");
        Console.WriteLine($"Replace: {replaced}");

        // Trim, TrimStart, TrimEnd: Removes leading and trailing whitespace characters
        string trimmed = text.Trim();
        string trimmedStart = text.TrimStart();
        string trimmedEnd = text.TrimEnd();
        Console.WriteLine($"Trim: '{trimmed}'");
        Console.WriteLine($"TrimStart: '{trimmedStart}'");
        Console.WriteLine($"TrimEnd: '{trimmedEnd}'");

        // Split: Splits the string into an array of substrings based on a specified delimiter
        string fruitsText = "apple,banana,orange";
        string[] fruits = fruitsText.Split(',');
        Console.WriteLine("Split:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Contains: Checks if a specified substring exists in the string
        bool containsWorld = text.Contains("world");
        Console.WriteLine($"Contains 'world': {containsWorld}");

        // StartsWith and EndsWith: Checks if the string starts or ends with a specified substring
        bool startsWithHello = text.StartsWith("Hello");
        bool endsWithSpace = text.EndsWith(" ");
        Console.WriteLine($"StartsWith 'Hello': {startsWithHello}");
        Console.WriteLine($"EndsWith space: {endsWithSpace}");

        // Format: Formats a string using placeholders
        string name = "Alice";
        int age = 30;
        string formatted = string.Format("My name is {0} and I am {1} years old.", name, age);
        Console.WriteLine($"Formatted: {formatted}");

        Console.ReadLine();
    }
}
