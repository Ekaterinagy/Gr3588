// Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю


int[] array = GenArray(100,1,11);
PrintArray(array);
printPairs (array);


//заполняем массив
int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] outArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(minValue, maxValue);
    }
    return outArray;
}
//Метод, выводящий на печать данные пользователю
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

void PrintArray(int[] arr) 
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

void printPairs (int[] array)
{
    Console.WriteLine("\nезурльтат");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]!=0)
        {
        int temp = array[i];
        int count = 0;
        int lastindex = -1;
        for (int j=i; j<array.Length;j++)
            {
                if (temp == array[j] && count == 0) 
                {
                    array[j] = 0;
                    count++;
                    lastindex = j;
                } else if (count>0 && temp == array[j]){
                    Console.WriteLine(temp + " - " + lastindex + ", "+j);
                    array[j] = 0;
                    count = 0;
                    lastindex = -1;
                }
            }
        }
    }
}

