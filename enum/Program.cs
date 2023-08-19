using System;

// Define an enum named DaysOfWeek
enum DaysOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Program
{
    static void Main(string[] args)
    {
        // Using enum values
        DaysOfWeek today = DaysOfWeek.Wednesday;

        Console.WriteLine("Today is: " + today);

        // Enum comparison
        if (today == DaysOfWeek.Wednesday)
        {
            Console.WriteLine("It's midweek!");
        }

        // Enum iteration
        Console.WriteLine("Days of the week:");
        foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
        {
            Console.WriteLine(day);
        }
    }
}
