/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9

* При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)


*/



        // Универсальный метод генерации и заполнение двумерного массива
        int ReadData(string line)
        {
            Console.Write(line);
            int number = int.Parse(Console.ReadLine() ?? "0");
            return number;
        }

        // Универсальный метод генерации и заполнение двумерного массива
        double[,] Fill2DIndexed(int countRow, int countColumn)
        {
            Random rand = new Random();
            double[,] array2D = new double[countRow, countColumn];

            for (int i = 0; i < countRow; i++)
            {
                for (int j = 0; j < countColumn; j++)
                {
                    array2D[i, j] = i + j;
                }
            }
            return array2D;
        }

        ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

        void Print2DArrayColor(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                  
                  string value = Math.Round (matrix[i,j]+ new Random().NextDouble(),2)+"";
                PrintColored(value);
                Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
//метод печатает каждый символ строки разным цветом
void PrintColored (string data)
    {
        char[] dataArray = data.ToCharArray();
        for(int i=0;i<dataArray.Length;i++)
        {
        Console.ForegroundColor = col[new Random().Next(0, 16)];
        Console.Write(dataArray[i]);
        Console.ResetColor();
        }
       
    }

        int row = ReadData("Введите количество строк ");
        int column = ReadData("Введите количество столбцов ");
        double[,] arr2D = Fill2DIndexed(row, column);
        Print2DArrayColor(arr2D);
