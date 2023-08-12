namespace for_loops;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Counting from 1 to " + n + ":");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine("\nLoop completed.");

        Console.ReadLine();
    }
}
