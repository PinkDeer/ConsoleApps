using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cумма чисел";

            string var;
            int a, b;

            Console.WriteLine("Введите первое число:");
            var = Console.ReadLine();
            a = Convert.ToInt32(var);

            Console.WriteLine("Введите второе число:");
            var = Console.ReadLine();
            b = Convert.ToInt32(var);

            int result = a + b;

            Console.WriteLine($"Cумма чисел {result}.");

            Console.ReadKey();
        }
    }
}
