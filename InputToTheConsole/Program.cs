﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputToTheConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine($"Hello, {name}!");

            Console.ReadKey();
        }
    }
}
