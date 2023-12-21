using System;

class Program
{
    static void Main(string[] args)
    {
        int M = int.Parse(Console.ReadLine());; // Начальное значение M
        int N = int.Parse(Console.ReadLine());; // Конечное значение N
        
        PrintNaturalNumbers(M, N);
    }
    
    static void PrintNaturalNumbers(int currentNum, int endNum)
    {
        if (currentNum <= endNum)
        {
            Console.WriteLine(currentNum); // Выводим текущее число
            PrintNaturalNumbers(currentNum + 1, endNum); // Рекурсивно вызываем функцию со следующим числом
        }
    }
}