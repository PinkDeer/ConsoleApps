using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Терные операции";

            // Первый пример 

            bool accessAllowed;

            string storedPassword = "qwerty";
            string enteredPassword = Console.ReadLine();

            accessAllowed = enteredPassword == storedPassword ? true : false;
/*
            // Аналог

            if (enteredPassword == storedPassword)
            {
                accessAllowed = true;
            }
            else
            {
                accessAllowed = false;
            }
*/
            Console.WriteLine(accessAllowed);

            Console.ReadLine();

            // Второй пример

            int inputData = int.Parse(Console.ReadLine());


            int outputDate = inputData < 0 ? 0 : inputData;

            Console.WriteLine(outputDate);

            Console.ReadLine();
        }
    }
}
