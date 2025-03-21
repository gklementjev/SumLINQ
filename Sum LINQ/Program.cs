using System;
using System.Linq;

namespace Sum_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 7, 12, 19, 24, 31, 42, 55, 63, 78 };

            int sum = (from n in numbers
                       where n % 2 != 0
                       select n).Sum();

            Console.WriteLine($"Paaritute arvude summa: {sum}");
        }
    }
}

