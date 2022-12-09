/*
* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
* 6 -> да
* 7 -> да
* 1 -> нет
*/

int number = getValidNumber("Введите день недели: ");

bool isWeekEnd = number == 6 || number == 7;
bool isWorkDay = number >= 1 && number <=5; 
bool isDayOfWeek = isWeekEnd || isWorkDay;

if (isWeekEnd) {
    Console.WriteLine(number + " -> да");
}

if (isWorkDay) {
    Console.WriteLine(number + " -> нет");
}

if (!isDayOfWeek) {
    Console.WriteLine(number + " -> не день недели");
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
