// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


// Печать результата
void PrintResult(int prefix)
{
    Console.WriteLine(prefix);
}

int SumMNRec (int m, int n)
{
    if (m>=n) 
    {
        return n;
    }
    return m + SumMNRec(m+1,n);
    

}

int numberN = ReadData("Введите число N: ");
int numberM = ReadData("Введите число M: ");
if (numberM < numberN) 
{
    int temp = numberM;
    numberM = numberN;
    numberN = temp;
}
int resultLine = SumMNRec(numberN, numberM);

PrintResult(resultLine);
