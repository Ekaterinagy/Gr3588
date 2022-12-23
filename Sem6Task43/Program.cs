/*
№43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

//==решение==
int b1 = ReadData("Введите b1: ");
int k1 = ReadData("Введите k1: ");
int b2 = ReadData("Введите b2: ");
int k2 = ReadData("Введите k2: ");

double x = getLineCollisionX(b1,k1,b2,k2);
double y = getLineY(b1,k1,b2,k2,x);

prettyPrintResult(b1,k1,b2,k2,x,y);

//==методы==

// Печать результата в отформатированном виде
void prettyPrintResult(int b1,int k1, int b2, int k2, double x, double y)
{
    
    Console.WriteLine("b1 = {0}, k1 = {1}, b2 = {2}, k2 = {3} -> ({4};{5})",
    b1,k1,b2,k2,x,y
    );
}

// Решение Уравнения y = k1 * x + b1, y = k2 * x + b2 или k1 * x + b1 =  k2 * x + b2
double getLineCollisionX(int b1,int k1, int b2, int k2)
{
    if (k1 == k2)
    {
        Console.WriteLine("Уравнение не имеет решения: k1 = k2 ({0} = {1})",k1,k2);
        Environment.Exit(0);
    }
    return (double)(b2-b1)/(k1-k2);
}

// считаем y по любому из 2х уравнений 
double getLineY(int b1,int k1, int b2, int k2, double x)
{
    return (double)(k1*x + b1);
}

// считываем ввод пользователя
int ReadData(string message) 
{
    Console.Write(message);
    string? value = Console.ReadLine();
    int result = -1;
    if (value == null)
    {
        Console.WriteLine("Пустое значение, выход");
        Environment.Exit(0);
    }
      Boolean parsed =  int.TryParse(value,out result);
    if (!parsed)
    {
        Console.WriteLine("Ошибка при определинии числа, выход");
        Environment.Exit(0);
    }
    return result;
}