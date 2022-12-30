// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//чтение данных с консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] Fill2DIndexed1(int countRow1, int countColumn1)
{
    System.Random rand = new System.Random();
    int[,] array2D1 = new int[countRow1, countColumn1];

    for (int i = 0; i < countRow1; i++)
    {
        for (int j = 0; j < countColumn1; j++)
        {
            array2D1[i, j] = rand.Next(1,200);
        }
    }
    return array2D1;
}
int[,] Fill2DIndexed2(int countRow2, int countColumn2)
{
    System.Random rand = new System.Random();
    int[,] array2D2 = new int[countRow2, countColumn2];

    for (int i = 0; i < countRow2; i++)
    {
        for (int j = 0; j < countColumn2; j++)
        {
            array2D2[i, j] = rand.Next(1,200);
        }
    }
    return array2D2;
}
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

void Print2DArrayColor(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(matrix[i, j]+"       ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}


       static int[,] Multiplication(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить!!!");
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i,j] += a[i,k] * b[k,j];
                    }
                }
            }
            return r;
        }
  


int row1 = ReadData("Введите количество строк ");
int column1 = ReadData("Введите количество столбцов ");

int row2 = ReadData("Введите количество строк ");
int column2 = ReadData("Введите количество столбцов ");
int[,] arr2D1 = Fill2DIndexed1(row1, column1);

int[,] arr2D2 = Fill2DIndexed2(row2, column2);
Console.WriteLine("1 матрица: ");
Print2DArrayColor(arr2D1);
Console.WriteLine("2 матрица: ");
Print2DArrayColor(arr2D2);

Console.WriteLine("Произведение матриц: ");
int[,] increaseArray = Multiplication(arr2D1, arr2D2);
Print2DArrayColor(increaseArray);