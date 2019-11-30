using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @break
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Title = "Операторы break и continue";

            // break

            for (int i = 0; i < 100; i++)
            {
                string msg = Console.ReadLine();

                if (msg == "exit")
                {
                    break;
                }

                Console.WriteLine(i);
            }

            Console.ReadLine();

            // continue

            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
