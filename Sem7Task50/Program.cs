// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
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
            
            Console.Write(matrix[i, j]+"_____".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Универсальный метод генерации и заполнение двумерного массива
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

void PrintData(int element)
{
    if(element==-1)
{
    Console.WriteLine("Элемент не существует");

}
else
{
    Console.WriteLine("Найдено число " + element);
}
}

int SearchElem (int[,]arr, int x, int y)
{
    int element=-1;
    if(x<arr.GetLength(0) && y<arr.GetLength(1))
    {
        element=arr[x,y];
    }
    return element;

}
int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DIndexed(row, column);
Print2DArrayColor(arr2D);
int x= ReadData("Введите X: ");
int y= ReadData("Введите Y: ");
int element = SearchElem (arr2D, x,y);
PrintData(element);
