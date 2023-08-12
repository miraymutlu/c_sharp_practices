namespace switch_case;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select a day of the week (1-7):");
        int dayNumber = int.Parse(Console.ReadLine());

        string dayName;

        switch (dayNumber)
        {
            case 1:
                dayName = "Sunday";
                break;
            case 2:
                dayName = "Monday";
                break;
            case 3:
                dayName = "Tuesday";
                break;
            case 4:
                dayName = "Wednesday";
                break;
            case 5:
                dayName = "Thursday";
                break;
            case 6:
                dayName = "Friday";
                break;
            case 7:
                dayName = "Saturday";
                break;
            default:
                dayName = "Invalid day number";
                break;
        }

        Console.WriteLine("You selected: " + dayName);

        Console.ReadLine();
    }
}
