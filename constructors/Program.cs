using System;

class MyClass
{
    // Instance variables
    private int value;

    // Instance constructor with parameters
    public MyClass(int val)
    {
        value = val;
        Console.WriteLine("Instance constructor called with value: " + val);
    }

    // Instance constructor without parameters (default constructor)
    public MyClass()
    {
        value = 0;
        Console.WriteLine("Default instance constructor called.");
    }

    // Static constructor
    static MyClass()
    {
        Console.WriteLine("Static constructor called.");
    }

    // Instance method
    public void DisplayValue()
    {
        Console.WriteLine("Value: " + value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances using different constructors
        MyClass obj1 = new MyClass(10); // Instance constructor with parameter
        MyClass obj2 = new MyClass();   // Default instance constructor

        // Calling instance methods
        obj1.DisplayValue();
        obj2.DisplayValue();
    }
}
