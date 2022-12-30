// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Универсальный метод генерации и заполнение двумерного массива
int[,] Fill2DIndexed(int countRow, int countColumn)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    int number = 1;
    int startIndex=0;
    int finishIndex=countColumn;
    int currentIndex=0;
    int secondStartIndex = 0;

    int columnSize = countColumn;
    int rowSize = countRow;


for (int i = 0 ; i < 2 ; i ++ )
{
    number = FillRight(array2D, startIndex,finishIndex,currentIndex,number);
    finishIndex=countRow;
    currentIndex=countColumn;
    countColumn=countColumn-1;
    number = FillDown(array2D,startIndex,finishIndex,currentIndex-1,number);
    startIndex = countColumn;
    countRow--;
    number = FillLeft(array2D,startIndex-1,secondStartIndex-1,countRow,number);
    number = FillUp(array2D,countRow-1,secondStartIndex,secondStartIndex,number);
    secondStartIndex++;
    startIndex = secondStartIndex;
    finishIndex = countColumn-1;
    currentIndex = secondStartIndex;
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
// заполнение вправо
int FillRight(int[,]array,int startIndex, int finishIndex, int rowIndex,int number)
{
for (int i = startIndex; i<finishIndex;i++)
{
    array[rowIndex,i]=number;
    number++;

}
return number;
}
// заполнение вниз
int FillDown(int[,]array,int startIndex, int finishIndex, int columnIndex,int number)
{
for (int i = startIndex; i<finishIndex;i++)
{
    array[i,columnIndex]=number;
    number++;

}
return number;
}
// заполнение влево
int FillLeft(int[,]array,int startIndex, int finishIndex, int rowIndex,int number)
{
for (int i = startIndex; i>finishIndex;i--)
{
    array[rowIndex,i]=number;
    number++;

}
return number;
}
// заполнение вверх
int FillUp(int[,]array,int startIndex, int finishIndex, int columnIndex,int number)
{
for (int i = startIndex; i>finishIndex;i--)
{
    array[i,columnIndex]=number;
    number++;

}
return number;
}


int[,] arr2D = Fill2DIndexed(4, 4);
Print2DArrayColor(arr2D);