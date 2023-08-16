using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace hw2_1;
class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number <= 3) return true;

        if (number % 2 == 0 || number % 3 == 0) return false;

        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }

        return true;
    }
    static void Main(string[] args)
    {
        ArrayList arrayList1 = new ArrayList();
        ArrayList arrayList2 = new ArrayList(); 
        Console.WriteLine("Enter 20 numbers: ");
        for(int i=0; i<20; i++){
            int input;
            if (!int.TryParse(Console.ReadLine(), out input) || input < 0)
                {
                    Console.WriteLine("Enter a positive integer number.");
                    input = int.Parse(Console.ReadLine());
                }
            if(IsPrime(input)==true){
                arrayList1.Add(input);
            }else{
                arrayList2.Add(input);
            }
        }
        arrayList1 = new ArrayList(arrayList1.Cast<int>().OrderByDescending(x => x).ToArray());
        arrayList2 = new ArrayList(arrayList2.Cast<int>().OrderByDescending(x => x).ToArray());
        foreach (var item in arrayList1){
                Console.Write(item+" ");
        }       Console.WriteLine();
        foreach (var item in arrayList2){
                Console.Write(item+" ");
        }       Console.WriteLine();
        int sum1 = arrayList1.Cast<int>().Sum();
        int sum2 = arrayList2.Cast<int>().Sum();
        int length1 = arrayList1.Count;
        int length2 = arrayList2.Count;
        Console.WriteLine(sum1/length1);
        Console.WriteLine(sum2/length2);
    }
}
