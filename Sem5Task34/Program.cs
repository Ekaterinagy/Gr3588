// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1
// * Отсортировать массив методом пузырька

int len = ReadData("Введите размер массива ");
int[] array = GenArray(len, 100, 999);
Print1DArr(array);
int count = CountEven(array);
Console.WriteLine("Количество четных чисел: "+ count);
BubbleSort(array);
Print1DArr(array);


//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

//заполняем массив
int[] GenArray(int len, int minValue, int maxValue)

{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}
void Print1DArr(int[] arr)
{
    Console.Write("Массив случайных чисел: ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}
//метод расчета количества четных чисел в массиве
int CountEven(int[] arr)
{
    int res=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(IsEven(arr[i]))
        {
            res++;
        }
        
    }
    return res;
}
//число четное: да/нет
bool IsEven(int value)
{
    return value % 2 == 0;
   
}
//сортировка методом пузырька
void BubbleSort(int[] array)
{

    for (int i=0;i<array.Length-1;i++)
    {
      int maxIndex=i;
    for(int j=i;j<array.Length-1;j++)
    {
        if ( array[maxIndex]<array[j+1])
        {
            maxIndex=j+1;
        }
    }
    int temp = array[i];
    array[i]=array[maxIndex];
    array[maxIndex]=temp;
}
}
//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}