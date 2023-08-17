using System;

class Student
{
    // Private fields (encapsulated data)
    private string name;
    private int age;

    // Property for 'Name' with get and set accessors
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Property for 'Age' with get accessor and validation
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0 && value <= 150) // Assuming a reasonable age range
                age = value;
            else
                Console.WriteLine("Invalid age value");
        }
    }

    // Constructor
    public Student(string initialName, int initialAge)
    {
        Name = initialName;
        Age = initialAge;
    }

    // Method to display student information
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a Student object using the constructor
        Student student = new Student("Alice", 20);

        // Accessing properties to set and get values
        student.Name = "Bob"; // Setting the 'Name' property
        student.Age = 25;     // Setting the 'Age' property

        // Displaying student information
        student.DisplayInfo();
    }
}
