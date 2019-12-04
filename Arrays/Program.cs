using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Массивы";

            int[] myArray; // объяление массива

            myArray = new int[5];  // выделение места в оперативной памяти
             
            myArray[1] = 4; // задать значение элементу массива

            int a = myArray[1]; // присвоить переменной значения элемента из массива

            Console.WriteLine(myArray[1]);
            Console.WriteLine(a);
            Console.WriteLine(myArray.Length);

            Console.ReadLine();
        }
    }
}
