using System;
using System.Globalization;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Конвертация дроби с точкой";

            string str = "1.6";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            double c = Convert.ToDouble(str, numberFormatInfo);

            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
