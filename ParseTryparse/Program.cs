using System;

namespace ParseTryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Parse и TryParse";

            // Распарсить целое число. Метод Parse
            string str = "5";
            int a = int.Parse(str);
            Console.WriteLine(a);

            // Распарсить доброе число с точкой. Метод Parse
            str = "5.4";
            
            // Обработка исключения
            try
            {
                double b = double.Parse(str);
                Console.WriteLine("Успешная конвертация");
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка при конертации");
            }

            // Распарсить дробь. Метод TryParse

            str = "3fdg";
            int c;

            bool resutl = int.TryParse(str, out c);

            if (resutl)
            {
                Console.WriteLine($"Операция успешна {c}");
            }
            else
            {
                Console.WriteLine("Не удалось конвертировать!");
            }

            Console.ReadKey();
        }
    }
}
