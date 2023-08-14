namespace datetime_methods;
class Program
{
    static void Main(string[] args)
    {
        // Creating a DateTime object for the current date and time
        DateTime currentDateTime = DateTime.Now;

        Console.WriteLine($"Current Date and Time: {currentDateTime}");

        // Accessing individual components of the DateTime object
        int year = currentDateTime.Year;
        int month = currentDateTime.Month;
        int day = currentDateTime.Day;
        int hour = currentDateTime.Hour;
        int minute = currentDateTime.Minute;
        int second = currentDateTime.Second;

        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Month: {month}");
        Console.WriteLine($"Day: {day}");
        Console.WriteLine($"Hour: {hour}");
        Console.WriteLine($"Minute: {minute}");
        Console.WriteLine($"Second: {second}");

        // Creating a custom DateTime object
        DateTime customDateTime = new DateTime(2023, 8, 15, 14, 30, 0);

        // Adding and subtracting time intervals
        DateTime futureDateTime = customDateTime.AddHours(12);
        DateTime pastDateTime = customDateTime.AddMonths(-1);

        Console.WriteLine($"Custom Date and Time: {customDateTime}");
        Console.WriteLine($"Future Date and Time: {futureDateTime}");
        Console.WriteLine($"Past Date and Time: {pastDateTime}");

        // Formatting DateTime to string
        string formattedDateTime = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        Console.WriteLine($"Formatted DateTime: {formattedDateTime}");

        // Parsing a string to DateTime
        string dateString = "2023-08-20 16:45:00";
        DateTime parsedDateTime = DateTime.ParseExact(dateString, "yyyy-MM-dd HH:mm:ss", null);
        Console.WriteLine($"Parsed DateTime: {parsedDateTime}");

        // Calculating the difference between two DateTime objects
        TimeSpan timeDifference = customDateTime - currentDateTime;
        Console.WriteLine($"Time Difference: {timeDifference.Days} days, {timeDifference.Hours} hours");

        Console.ReadLine();
    }
}
