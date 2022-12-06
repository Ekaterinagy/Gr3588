/*
* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
* 4 -> да
* -3 -> нет
* 7 -> нет
*/
//main
Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(number + " -> " + (isEven(number) ? "да" : "нет"));

//methods

bool isEven(int number){
    return number % 2 == 0;
}
