using System;
using System.Collections;

namespace arraylists;
class Program
{
    static void Main(string[] args)
    {
        // Create an ArrayList
        ArrayList list = new ArrayList();

        // Adding elements to the ArrayList
        list.Add(42);
        list.Add("Hello");
        list.Add(3.14);

        Console.WriteLine("ArrayList elements:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // Removing an element by value
        list.Remove("Hello");

        Console.WriteLine("\nAfter removing 'Hello':");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // Checking if an element exists
        bool contains42 = list.Contains(42);
        Console.WriteLine($"\nContains 42: {contains42}");

        // Finding the index of an element
        int indexOf314 = list.IndexOf(3.14);
        Console.WriteLine($"Index of 3.14: {indexOf314}");

        // Clearing the ArrayList
        list.Clear();

        Console.WriteLine("\nAfter clearing:");
        Console.WriteLine($"Count: {list.Count}");

        Console.ReadLine();
    }
}
