using System;

namespace NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Вложенные циклы";

            // Пример

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Цикл 1 итерация: " + i);
                for (int j = 1; j <= 4; j++)
                {
                    Console.WriteLine("\tЦикл 2 итерация: " + j);
                    for (int k = 1; k <= 2; k++)
                    {
                        Console.WriteLine("\t\tЦикл 3 итерация: " + k);
                    }
                }
            }

            Console.ReadLine();

            // Нарисовать многоугольник

            /*            Console.Write("Введите высоту многоугольника: ");
                        int height = int.Parse(Console.ReadLine());

                        Console.Write("Введите ширину многоугольника: ");
                        int width = int.Parse(Console.ReadLine());

                        Console.ReadLine();

                        for (int j = 0; j < height; j++)
                        {
                            for (int i = 0; i < width; i++)
                            {
                                Console.Write("#");
                            }
                            Console.WriteLine();
                        }

                        Console.ReadLine();*/

        }
    }      
}
