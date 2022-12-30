// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//  которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// Универсальный метод генерации и заполнение трехмерного массива
int[,,] Fill3DIndexed(int countRow, int countColumn,int countDeep,int[] uniqueNums)
{

   int numIndex = 0;
    int[,,] array3D = new int[countRow, countColumn,countDeep];

    for (int z = 0; z < countRow; z++)
    {
        for (int i = 0; i < countColumn; i++)
        {
            for (int j = 0; j<countDeep;j++)
            {
            array3D[z ,i, j] = uniqueNums[numIndex];
            numIndex++;
            }
        }
    }
    return array3D;
}

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

void Print3DArrayColor(int[,,] cube)
{
    for (int z = 0; z < cube.GetLength(2); z++)
    {
        Console.ForegroundColor = col[new System.Random().Next(0, 16)];
        for (int i = 0; i < cube.GetLength(0); i++)
        {
            for (int j = 0; j < cube.GetLength(1); j++)
             {
                Console.Write(cube[z, i, j]+"("+i+","+j+","+z+")"+"       ".Substring(cube[z, i, j].ToString().Length));
             }
       
        Console.WriteLine();
        }
         Console.ResetColor();
    }
}
//метод мешает массив
int[] Shuffle() 

{
    int[] array = new int[90];
    for (int i=0; i<90;i++)
    {
        array[i]=i+10;
    }
    System.Random rand = new System.Random();
    for (int i=array.Length-1;i>0; i--)
    {
        int j = rand.Next(0,i);
		int temp = array[j];
		array[j] = array[i];
		array[i] = temp;
	}
   return array; 
}


// Метод печатает массив
void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}
int[] uniqueNums = Shuffle();
PrintArr(uniqueNums);
int[,,] cube = Fill3DIndexed(4,4,4,uniqueNums);
Print3DArrayColor(cube);
