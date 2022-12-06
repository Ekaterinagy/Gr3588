/*
* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
* 2, 3, 7 -> 7
* 44 5 78 -> 78
* 22 3 9 -> 22
*/

//main
Console.Write("Введите первое число: ");

string? firstNumberStr = Console.ReadLine();
int firstNumber = int.Parse(firstNumberStr??"0");

Console.Write("Введите второе число: ");

string? secondNumberStr = Console.ReadLine();
int secondNumber = int.Parse(secondNumberStr??"0"); 

Console.Write("Введите третье число: ");

string? thirdNumberStr = Console.ReadLine();
int thirdNumber = int.Parse(thirdNumberStr??"0"); 

Console.WriteLine(
    "Вы ввели:\n\tпервое число: " + firstNumber 
    + "\n\tвторое число: " + secondNumber
    + "\n\tтретье число: " + thirdNumber);

Console.WriteLine(
    firstNumber + ", "
    + secondNumber + ", "
    + thirdNumber
    + " -> max = " + max(firstNumber,secondNumber,thirdNumber));

//methods

int max(int a, int b, int c) {

    int max = a;

    if (max<b) {
        max = b;
    }
    if (max<c) {
        max = c;
    }

    return max;
}
