namespace hw2_2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 20 numbers: ");
        int[] arr = new int[20];
        for(int i=0; i<20; i++){
            int input = int.Parse(Console.ReadLine());
            arr[i]=input;
        }
        Array.Sort(arr);
        double avg1 = (arr[0]+arr[1]+arr[2])/3.0;
        double avg2 = (arr[17]+arr[18]+arr[19])/3.0;

        Console.WriteLine(avg1);
        Console.WriteLine(avg2);
    }
}
