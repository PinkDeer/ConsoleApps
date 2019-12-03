using System;

namespace NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Вложенные циклы";

            // Пример

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Цикл 1 итерация: " + i);
                for (int j = 1; j <= 4; j++)
                {
                    Console.WriteLine("\tЦикл 2 итерация: " + j);
                    for (int k = 1; k <= 2; k++)
                    {
                        Console.WriteLine("\t\tЦикл 3 итерация: " + k);
                    }
                }
            }

            Console.ReadLine();

            // Нарисовать многоугольник
            /*
                        Console.Write("Введите высоту многоугольника: ");
                        int height = int.Parse(Console.ReadLine());

                        Console.Write("Введите ширину многоугольника: ");
                        int width = int.Parse(Console.ReadLine());

                        Console.ReadLine();

                        for (int j = 0; j < height; j++)
                        {
                            for (int i = 0; i < width; i++)
                            {
                                Console.Write("#");
                            }
                            Console.WriteLine();
                        }

                        Console.ReadLine();
            */

        }



        // Пример 1 с вложеным массивом

        static int[,] GetRandomArray(int rows, int columns)
        {
            Random random = new Random();

            var result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = random.Next(100);
                }

            }
            return result;
        }

        static void Main(string[] args)
        {
            int rows = 5;
            int columns = 10;
            var myArray = GetRandomArray(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{myArray[i, j]}\t");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }


        // Пример 2 с вложенным массивом
/*
        static void Main(string[] args)
        {
            var gamesInfo = GetGamesInfo();

            for (int i = 0; i < gamesInfo.Count; i++)
            {
                Console.WriteLine($"{gamesInfo[i].TypeOfGame}:");

                for (int j = 0; j < gamesInfo[i].Games.Count; j++)
                {
                    Console.WriteLine($"{gamesInfo[i].Games[j].Name}");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        static List<GameInfo> GetGamesInfo()
        {
            return new List<GameInfo>()
            {
                new GameInfo()
                {
                    TypeOfGame = GameType.RPG,
                    Games = new List<Game>()
                    {
                        new Game(){Name = "Fallout 4"},
                        new Game(){Name = "Gothic 2"},
                        new Game(){Name = "The Elder Scrolls 3: Morrowind"}
                    }
                },
                new GameInfo()
                {
                    TypeOfGame = GameType.Shooter,
                    Games = new List<Game>()
                    {
                        new Game(){Name = "CS"},
                        new Game(){Name = "BF 2"},
                        new Game(){Name = "Doom"}
                    }
                },
                new GameInfo()
                {
                    TypeOfGame = GameType.Strategy,
                    Games = new List<Game>()
                    {
                        new Game(){Name = "Civilization VI"},
                        new Game(){Name = "Rome: Total War"},
                        new Game(){Name = "Starcraft II"}
                    }
                }
            };
        }
*/
    }      
}
