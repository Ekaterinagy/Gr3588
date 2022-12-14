// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12




int number = ReadData("Введите число А:");


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод выводит данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

//метод считает сумму цифр
int SumDigit(int num)
{
    int res1 = 0;
    while(num>0)
    {
        res1+=num%10;
        num=num/10;
    
    }
    return res1;
}
// метод считает сумму цифр используя CharArray
int VariantString(int num) 
{
    char[] charArray = (num +"").ToCharArray(); 
    int res2 = 0;
    for (int i=0;i<charArray.Length;i++)
    {
        res2 +=int.Parse(charArray[i]+"");
    }
    return res2;
}

Console.WriteLine("Вариант 1");
DateTime d1 = DateTime.Now;
int res1 = SumDigit(number);
Console.WriteLine(DateTime.Now - d1);
PrintData("Сумма цифр в числе равна: " + res1 );

Console.WriteLine("Вариант 2");
DateTime d2 = DateTime.Now;
int res2 = VariantString(number);
Console.WriteLine(DateTime.Now - d2);
PrintData("Сумма цифр в числе равна: " + res2 );