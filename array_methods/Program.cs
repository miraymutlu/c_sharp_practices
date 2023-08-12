namespace array_methods;
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Length property: Gets the number of elements in the array
        int length = numbers.Length;
        Console.WriteLine("Length of the array: " + length);

        // IndexOf method: Returns the index of the first occurrence of a specified value
        int indexOf30 = Array.IndexOf(numbers, 30);
        Console.WriteLine("Index of 30: " + indexOf30);

        // Sort method: Sorts the elements in ascending order
        Array.Sort(numbers);
        Console.WriteLine("Sorted array:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();

        // Reverse method: Reverses the order of elements
        Array.Reverse(numbers);
        Console.WriteLine("Reversed array:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();

        // Clear method: Sets a range of elements to their default values
        Array.Clear(numbers, 1, 2); // Clear elements from index 1 to 2
        Console.WriteLine("Array after clearing elements:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        Console.ReadLine();
    }
}
