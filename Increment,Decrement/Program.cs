using System;

namespace Increment_Decrement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Инкремент и декремент";

            // Унарные операции

            // Инкремент
            int a = 0;
            a++; // Постфиксная форма. Аналог a = a + 1;
            Console.WriteLine(a);

            // Декремент
            int b = 0;
            b--; // Постфиксная форма. Аналог a = a - 1;
            Console.WriteLine(b);

            // У префиксной формы выше приоритет

            int c = 1;
            Console.WriteLine(c++);

            int d = 1;
            Console.WriteLine(++d);

            int e = 1;
            e = ++e * e;
            Console.WriteLine(e);
            int f = 1;
            f = f++ * f;
            Console.WriteLine(f);

            Console.ReadKey();
        }
    }
}
