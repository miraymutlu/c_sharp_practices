namespace generic_collections;
class Program
{
    static void Main(string[] args)
    {
        // List<T>: A dynamic-size list
        List<int> numbers = new List<int>();
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        Console.WriteLine("List<T>:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Dictionary<TKey, TValue>: A collection of key-value pairs
        Dictionary<string, int> ages = new Dictionary<string, int>();
        ages.Add("Alice", 25);
        ages.Add("Bob", 30);
        ages.Add("Carol", 28);
        Console.WriteLine("\nDictionary<TKey, TValue>:");
        foreach (var kvp in ages)
        {
            Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
        }

        // Queue<T>: A first-in, first-out (FIFO) collection
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");
        Console.WriteLine("\nQueue<T>:");
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }

        // Stack<T>: A last-in, first-out (LIFO) collection
        Stack<string> stack = new Stack<string>();
        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");
        Console.WriteLine("\nStack<T>:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }

        Console.ReadLine();
    }

}

