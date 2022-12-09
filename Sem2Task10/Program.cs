/*
* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
* 456 -> 5
* 782 -> 8
* 918 -> 1
*/

int number= getValidNumber("Введите трехзначное число: ");
int result = number;
result = result/10;
result = result%10;

Console.WriteLine(number + " -> " + result);

int getValidNumber(string message){
    Console.Write(message);
    int number;
    bool isNumber = int.TryParse(Console.ReadLine(), out number);
     if (!isNumber){
        Console.WriteLine("Вы ввели не число, выход.");
        Environment.Exit(0);
    }
    return number;
}

