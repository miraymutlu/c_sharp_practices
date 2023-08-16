namespace hw2_3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write a sentences: ");
        string input = Console.ReadLine();
        List<char> list = new List<char>();
        for(int i=0; i<input.Length; i++){
           input.ToLower();
           if(input[i]=='a'||input[i]=='e'||input[i]=='i'||input[i]=='ı'||input[i]=='o'||input[i]=='ö'||input[i]=='u'||input[i]=='ü'){
                list.Add(input[i]);
           } 
        }
        foreach(char letter in list){
            Console.WriteLine(letter);
        }
    }
}
