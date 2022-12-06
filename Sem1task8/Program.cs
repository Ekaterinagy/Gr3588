/*
* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
* 5 -> 2, 4
* 8 -> 2, 4, 6, 8
*/

//main
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()??"0");

string result = number + " -> ";

if (number>=2){
    result = result + "2";
} 

for (int i = 4 ; i <= number ; i+=2){
    result+= ","+i;
}

Console.WriteLine(result);
