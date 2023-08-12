namespace methods;
class Program
{
    // Method that calculates the sum of two numbers
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Method that greets a person
    static void Greet(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }

    // Method that prints a message multiple times
    static void PrintMessage(string message, int times)
    {
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine(message);
        }
    }

    static void Main()
    {
        // Calling the Add method
        int sum = Add(5, 3);
        Console.WriteLine("Sum: " + sum);

        // Calling the Greet method
        Greet("Alice");

        // Calling the PrintMessage method
        PrintMessage("This is a message.", 3);

        Console.ReadLine();
    }
}
