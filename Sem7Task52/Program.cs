// №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Универсальный метод генерации и заполнение двумерного массива
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] Fill2DIndexed(int countRow, int countColumn)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

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
void PrintData(string msg, int result)
{
    Console.WriteLine(msg + result);
}

void PrintArray(double[] arr) 
{
    Console.Write("Среднее арифметическое каждого столбца: [");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ";  ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

double[] AwgColumn (int[,] array)
{
    double[] awgArray = new double[array.GetLength(1)];
    for(int j=0; j<array.GetLength(1); j++)
    {
        awgArray[j]=0;
        for(int i=0;i<array.GetLength(0);i++)
        {
            awgArray[j]+=array[i,j];
        }
    awgArray[j]/=awgArray.GetLength(0);
    }
    return awgArray;
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DIndexed(row, column);
Print2DArrayColor(arr2D);
double[] awgArray = AwgColumn(arr2D);
PrintArray(awgArray);