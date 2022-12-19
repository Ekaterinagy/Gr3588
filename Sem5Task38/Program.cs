// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6


double[] array = GenArray(10,1,11);
PrintArray(array);
printMaxMinusMin(array);


//заполняем массив
double [] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
   double [] outArray = new double[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().NextDouble ()*(maxValue-minValue)+maxValue;
    }
    return outArray;
}
//Метод, выводящий на печать данные пользователю
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

void PrintArray(double[] arr) 
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

void printMaxMinusMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0 ; i <array.Length; i++ )
    {
    if (max < array[i])
    {
        max = array[i];
    }
    if (min > array[i])
    {
        min = array[i];
    }
    }
    double result = max - min;
    Console.WriteLine("\nmax: "+max);
    Console.WriteLine("min: "+min);
    Console.WriteLine("Разница " + result);

}