using System;

namespace @for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Цикл for";

            // for

            int limit = int.Parse(Console.ReadLine());

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(i);
            }

            // Параметры не обязательны

            //for (;;)
            //{
            //    Console.WriteLine("...");
            //    System.Threading.Thread.Sleep(300);
            //    break;
            //}


            // Без первого параметра

            //int a = 0;

            //for (; a < 3; a++)
            //{
            //    Console.WriteLine("for_1: " + a);
            //}
            //for (; a < 5; a++)
            //{
            //    Console.WriteLine("for_2: " + a);
            //}

            // Без третьего параметра

            //for (int x = 0; x < 5;)
            //{
            //    x++;
            //    Console.WriteLine(x);
            //    //x++;
            //}

            // Несколько переменных

            //for (int i = 0, j = 5; i < 10; i++, j++)
            //{
            //    Console.WriteLine("i: " + i);
            //    Console.WriteLine("j: " + j);
            //}

            // Несколько условий

            //for (int i = 0, j = 5; i < 10 && j < 12; i++, j++)
            //{
            //    Console.WriteLine("i: " + i);
            //    Console.WriteLine("j: " + j);
            //}

            // В обратом порядке

            //for (int i = int.Parse(Console.ReadLine()); i > 0; i--) // допустим запрос из первого параметра, если есть необходимость в ограничение видимости
            //{
            //    Console.WriteLine(i);
            //}

            // Всё вместе

            //for (int i = 0, j= 5; i < 5; i++, j--)
            //{
            //    Console.WriteLine("i: " + i);
            //    Console.WriteLine("j: " + j);
            //}

            //Console.ReadLine();
        }
    }
}
