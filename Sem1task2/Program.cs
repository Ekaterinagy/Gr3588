/* 
* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
* a = 5; b = 7 -> max = 7
* a = 2 b = 10 -> max = 10
* a = -9 b = -3 -> max = -3 
*/

//main

Console.Write("Введите первое число: ");

string? firstNumberStr = Console.ReadLine();
int firstNumber = int.Parse(firstNumberStr??"0");


Console.Write("Введите второе число: ");

string? secondNumberStr = Console.ReadLine();
int secondNumber = int.Parse(secondNumberStr??"0");  

Console.WriteLine("Вы ввели:\n\tпервое число: "+firstNumber + "\n\tвторое число: "+ secondNumber);

Console.WriteLine("a = "+firstNumber +" b = "+secondNumber + " -> max = "+max(firstNumber,secondNumber));

//methods 

int max(int a, int b) {
    return a > b ? a : b;
}



