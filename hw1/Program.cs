namespace hw1;
class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter "+number+" numbers.");
        for(int i=0; i<number; i++){
            int numbers = int.Parse(Console.ReadLine());
            if(numbers%2==0){
                Console.WriteLine(numbers+"is even.");
            }
        }
        Console.WriteLine("Enter two numbers: ");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter "+number1+" numbers.");
        for(int i=0; i<number1; i++){
            int numbers = int.Parse(Console.ReadLine());
            if(numbers%number2==0){
                Console.WriteLine(numbers+"can be divided by "+number2);
            }
        }
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter "+number+" words.");
        List<string> array = new List<string>();
        for(int i=0; i<number; i++){
            array.Add(Console.ReadLine());
        }
        array.Reverse();
        for(int i=0; i<number; i++){
            Console.WriteLine(array[i]);
        }
        Console.WriteLine("Enter a sentences: ");
        string sentence = Console.ReadLine();
        int wordCount = sentence.Split(' ').Length;
        Console.WriteLine($"Number of words in the sentence: {wordCount}");
        int letterCount = sentence.Length;
        Console.WriteLine($"Number of letters in the sentence: {letterCount}");
    }
        
}

