/*
* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
* 645 -> 5
* 78 -> третьей цифры нет
* 32679 -> 6
*/

int number = getValidNumber("Введите число: ");

if (getDigitsCount(number)<3){
    Console.WriteLine(number + " -> третьей цифры нет");
} else {
    int result = number;
    while(getDigitsCount(result)>3){
    result = result/10;
    }
  result = result%10;
  Console.WriteLine(number + " -> " + result);
}

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

int getDigitsCount(int number){
    double dNumber = (double) number;
    return (int)(1 + Math.Log10(dNumber));
}
