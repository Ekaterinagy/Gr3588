// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Метод выводит данные пользователю
void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    PrintArr(arr);
}
//Метод генерирует массив
int[] GenArr(int num, int start, int finish)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(start, finish);
    }
    return arr;
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

int start = ReadData("Введите нижнюю границу: ");
int finish = ReadData("Введите верхнюю границу: ");
int arrLen = 8;
if (start>finish)
{
int temp = start;
start = finish;
finish = temp;
}

int[] arr = GenArr(arrLen,start,finish);

PrintData("Сгененрированный массив:",arr);