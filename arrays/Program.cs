namespace arrays;
class Program
{
    static void Main(string[] args)
    {
        // Creating and initializing an array of integers
        int[] numbers = new int[5]; // Creating an array of size 5
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;

        Console.WriteLine("Array of numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Element at index " + i + ": " + numbers[i]);
        }

        Console.WriteLine();

        // Creating and initializing an array of strings using array initializer
        string[] fruits = { "Apple", "Banana", "Orange", "Grapes" };

        Console.WriteLine("Array of fruits:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.ReadLine();
    }
}
