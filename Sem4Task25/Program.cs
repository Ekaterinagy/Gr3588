// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


int Num1 = ReadData("Введите число: ");
int Num2 = ReadData("Введите в какую степень возвести: ");

PrintData(Pow(Num1, Num2), Num1, Num2);



// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Метод выводит данные пользователю
void PrintData(int res, int Num1, int Num2)
{
    string result = Num1 + ", " + Num2 + " -> " + res;

    Console.WriteLine(result);
   

}

int Pow(int Num1, int Num2)
{
    int res = 1;
    for (int i = 1; i <= Num2; i++)
    {
        res = Num1 * res;
    }
    return res;
}

