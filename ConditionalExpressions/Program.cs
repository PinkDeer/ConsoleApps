using System;


namespace ConditionalExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Условные выражения";

            // Опраторы сравнения

            int a = 4;
            int b = 5;

            bool resault = a == b;
            Console.WriteLine(resault);

            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);

            Console.ReadLine();
        }
    }
}
