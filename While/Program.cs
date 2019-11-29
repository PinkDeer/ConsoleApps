using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Циклы while и do";

            //Цикл While

            int limit = int.Parse(Console.ReadLine());
                
            int count = 0; 
            while (count < limit)
            {
                count++;
                Console.WriteLine(count);
            }
            Console.ReadKey();

            //Цикл do

            int countDO = 0; // Если count 5, то на 5 завершится

            do
            {
                countDO++;
                Console.WriteLine(countDO);
            } while (countDO < 5);

            Console.ReadKey();
        }
    }
}
