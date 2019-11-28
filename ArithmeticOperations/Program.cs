using System;


namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Арифметические операции";
                
            // Сложение
            int a = 3;
            int b = 4;

            int result = a + b;
            Console.WriteLine(result);

            // Вычитание
            a = 3;
            b = 4;

            result = a - b;
            Console.WriteLine(result);

            // Умножение
            a = 3;
            b = 4;

            result = a * b;
            Console.WriteLine(result);

            // Деление (получим ноль)
            a = 3;
            b = 4;

            double result2 = a / b;
            Console.WriteLine(result2);

            // Деление (одно число в double)
            double c = 3;
            b = 4;

            result2 = c / b;
            Console.WriteLine(result2);

            // Деление. Приведение типов

            a = 3;
            b = 4;

            result2 = (double)a / b;
            Console.WriteLine(result2);

            // Остаток от деления

            a = 10;
            b = 4;

            result = a % b;
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
