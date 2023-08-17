using System;

// Define a struct named Point
struct Point
{
    public int X; // Field to store X-coordinate
    public int Y; // Field to store Y-coordinate

    // Constructor to initialize the fields
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Method to display the coordinates
    public void Display()
    {
        Console.WriteLine($"X: {X}, Y: {Y}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of the Point struct
        Point point1 = new Point(3, 5);
        Point point2 = new Point(7, 9);

        // Display the coordinates using the Display method
        Console.WriteLine("Point 1:");
        point1.Display();

        Console.WriteLine("Point 2:");
        point2.Display();
    }
}
