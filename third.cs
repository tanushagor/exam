using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        PrintArrayReverse(arr, arr.Length - 1);

        Console.ReadLine();
    }

    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index < 0)
        {
            return;
        }

        Console.WriteLine(arr[index]);
        PrintArrayReverse(arr, index - 1);
    }
}