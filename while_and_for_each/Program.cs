namespace while_and_for_each;
class Program
{
    static void Main(string[] args)
    {
        // Demonstrating the while loop
        Console.WriteLine("Using while loop:");
        int whileCounter = 1;
        while (whileCounter <= 5)
        {
            Console.WriteLine("While loop iteration #" + whileCounter);
            whileCounter++;
        }

        Console.WriteLine();

        // Demonstrating the foreach loop with a List
        Console.WriteLine("Using foreach loop with a List:");
        List<string> colors = new List<string> { "Red", "Green", "Blue", "Yellow" };
        foreach (string color in colors)
        {
            Console.WriteLine("Color: " + color);
        }

        Console.WriteLine();

        // Demonstrating the foreach loop with an array
        Console.WriteLine("Using foreach loop with an array:");
        string[] fruits = { "Apple", "Banana", "Orange", "Grapes" };
        foreach (string fruit in fruits)
        {
            Console.WriteLine("Fruit: " + fruit);
        }

        Console.ReadLine();
    }
}
