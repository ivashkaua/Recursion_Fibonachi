using System;

namespace Recursion
{
    class Program
    {
        static int Fibonachi(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input the number:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Result of Fibonachi raw of {n} is " + Fibonachi(n));
                Console.ReadLine();
                Console.Clear();

            }
        }
    }
}
