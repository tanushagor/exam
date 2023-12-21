using System;

namespace AckermannFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of m: ");
            int m = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Ackermann({m}, {n}) = {Ackermann(m, n)}");
        }
        
        static int Ackermann(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return Ackermann(m - 1, 1);
            }
            else
            {
                return Ackermann(m - 1, Ackermann(m, n - 1));
            }
        }
    }
}