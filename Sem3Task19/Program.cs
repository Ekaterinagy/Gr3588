// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
string Number = ReadData("Введите пятизназное число:"); 
char[] NumberArray = Number.ToCharArray();

Array.Reverse(NumberArray);

string Polindrom = new string (NumberArray);

if (Number.Equals(Polindrom))
 {
   PrintData("да", Number);

}
else {
    PrintData("нет",Number);
}

string ReadData(string num)
{
    Console.WriteLine(num);
    return Console.ReadLine()??"0";
}
void PrintData(string res,string Number) 
{    
     Console.WriteLine(Number + " -> " + res); 
} 