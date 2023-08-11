namespace exception_handling;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int result = 10 / num; // Potential division by zero

            Console.WriteLine("Result: " + result);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input format: " + ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Division by zero error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }

        Console.ReadLine();
    }
}
