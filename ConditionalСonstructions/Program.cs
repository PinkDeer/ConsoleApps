using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalСonstructions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Условные конструкции";

            // Пример с утверждением

            bool isInfected = false;

            if (isInfected)
            {
                Console.WriteLine("Персонаж инфицирован");
            }
            else
            {
                Console.WriteLine("Персонаж здоров");
            }

            Console.ReadLine();

            // Пример с выражением

            int a;

                a = int.Parse(Console.ReadLine());

            if (a == 5)
            {
                Console.WriteLine("a равна 5");
            }
            else
            {
                Console.WriteLine("a не равна 5");
            }

            Console.ReadKey();
        }
    }
}
