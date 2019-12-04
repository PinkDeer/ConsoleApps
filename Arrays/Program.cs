using System;
using System.Linq;

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

            // Способы инициализации массива

            int[] myArrayTwo = new int[5]; // В одну строку. Не допустимо не указывать сколько элементов 
            int[] myArrayThree = new int[5] {1, 5, 75, 2, 6 };  /* 1-ый способ добавления элементов.
            Необходимо указать столько элементов, сколько указано при выделении памяти. При добавлении элементов можно опустить второй int:
            int[] myArrayThree = new [5] {1, 5, 75, 2, 6 };*/
            int[] myArrayFour = new int[] { 1, 5, 75}; // 2-ой способ добавления элементов. Можно указывать сколько угодно элементов 
            int[] myArrayFive =  { 1, 5, 75 }; // При явном указывании элементов в массиве - сокращенная записть
            int[] myArraySix = Enumerable.Repeat(4, 10).ToArray(); // Добавить 10 элементов со значение 4
            int[] myArraySeven = Enumerable.Range(3,5).ToArray(); // 5 элементов, первое значение 3

            Console.ReadLine();

            // Перебор массива с помощью цикла for

            int[] Array = { 1, 4, 5, 7, 4 };

            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }

            Console.ReadLine();

        }
    }
}
