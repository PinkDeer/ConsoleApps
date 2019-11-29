using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Цикл While";
            int limit = int.Parse(Console.ReadLine());
                
            int count = 0; 
            while (count < limit)
            {
                count++;
                Console.WriteLine(count);
            }
            Console.ReadKey();
        }
    }
}
