using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Цикд do";

            int count = 0; // Если count 5, то на 5 завершится

            do
            {
                count++;
                Console.WriteLine(count);
            } while (count < 5);

            Console.ReadKey();
        }
    }
}
