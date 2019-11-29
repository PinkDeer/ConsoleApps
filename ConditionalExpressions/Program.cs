using System;


namespace ConditionalExpressions
{
    class Program
    {
        public static bool GetTemperature()
        {
            return true;
        }

        public static bool GetCoolingStatus()
        {
            return false;
        }


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
            /*
                        Логические операторы

                         && Сокращенное И
                         || Сокращенное ИЛИ
                         & И
                         | ИЛИ 
                         ! не
            */

            // Пример

            bool isInfected = false;

            if (!isInfected) // не false, значит true
            {
                Console.WriteLine("Персонаж здоров");
            }

            Console.ReadLine();

            // Ещё пример

            int fanSpeed = 0;

            bool isHighTemperature = false;
            bool hasNoCooling = fanSpeed <= 0;

            if  (isHighTemperature || hasNoCooling) // При использовании сокращенного оператора дальше проверка не идёт
            {
                Console.WriteLine("Угроза повреждения процессора!!!");
            }

            Console.ReadLine();

            // Ещё пример


            bool isHighTemperature2 = true;
            bool hasNoCooling2 = true;

            if (isHighTemperature2 & hasNoCooling2)
            {
                Console.WriteLine("Угроза повреждения процессора!!!");
            }

            Console.ReadLine();

            // Ещё пример

            if (GetTemperature() | GetCoolingStatus())
            {
                Console.WriteLine("Угроза повреждения процессора!!!");
            }

            Console.ReadLine();
        }
    }
}
