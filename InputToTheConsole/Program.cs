using System;

namespace InputToTheConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ввод данных в консоль";

            Console.WriteLine("Введите своё имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine($"Hello, {name}!");

            Console.ReadKey();
        }
    }
}
