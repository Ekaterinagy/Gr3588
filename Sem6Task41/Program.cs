/*№ 41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
пользователь.
	0, 7, 8, -2, -2 -> 2
	-1, -7, 567, 89, 223-> 3
* Пользователь вводит число нажатий, затем программа следит за нажатиями и
выдает сколько чисел больше 0 было введено.
*/

//---константы---
//количество символов, которые ожидается вводить с клавиатуры
int keysCount = 10;
int minus = 10;
string minusStr = "-";
//Вводить только положительные числа, иначе выводить все вкючая со знаком минус
bool onlyPositive = true;
//словарь символов
ConsoleKey[] numbers = {
ConsoleKey.D0,
ConsoleKey.D1,
ConsoleKey.D2,
ConsoleKey.D3,
ConsoleKey.D4,
ConsoleKey.D5,
ConsoleKey.D6,
ConsoleKey.D7,
ConsoleKey.D8,
ConsoleKey.D9,
ConsoleKey.OemMinus
};
ConsoleKey[] numbersPad = {
ConsoleKey.NumPad0,
ConsoleKey.NumPad1,
ConsoleKey.NumPad2,
ConsoleKey.NumPad3,
ConsoleKey.NumPad4,
ConsoleKey.NumPad5,
ConsoleKey.NumPad6,
ConsoleKey.NumPad7,
ConsoleKey.NumPad8,
ConsoleKey.NumPad9,
ConsoleKey.Subtract
};
//---решение---
Console.WriteLine("Наберите символы: ");
ConsoleKeyInfo[] data = ReadData(keysCount);
PrintData(data);

//---методы---
//считывает нажатия клавиш keysCount раз
ConsoleKeyInfo[] ReadData(int keysCount)
{
ConsoleKeyInfo[] data = new ConsoleKeyInfo[keysCount];
for (int i = 0; i < keysCount; i++)
{
ConsoleKeyInfo keyInf = Console.ReadKey();

data[i] = keyInf;
}
return data;
}

//выводит все числа из массива символов клавиатуры
void PrintData(ConsoleKeyInfo[] data)
{
string result = "";

//флаг начала последовательности цифр
bool nextNumber = false;
//флаг для учета первого знака перед цифрой
bool isAfterMinus = false;
string temp = "";
for (int i = 0; i< data.Length; i++)
{

int digit = GetDigit(data[i].Key);
 
   // для случаев "abc-"
if (IsMinus(data[i].Key) && nextNumber == false)
{

isAfterMinus = true;
}
// для случаев "-1" или "-0"
else if (isAfterMinus && digit !=-1)
{
//пропуск цифры 0 перед числом
 if (digit != 0)
 {
temp += minusStr + digit;
isAfterMinus = false;
nextNumber = true;
 }
}
// для случаев когда нет минуса и пишем первую цифру отличную от нуля
else if (nextNumber == false && digit >0 && !isAfterMinus)
{
temp+=digit;
nextNumber = true;
}
// для случаев когда число уже начали писать
else if (nextNumber == true && digit !=-1)
{
temp+= digit;
}
// для случаев когда вводили цифры и пришла не цифра "12345A" или "12345-"
else if (nextNumber == true && digit == -1)
{
if (!temp.Substring(0,1).Equals(minusStr) || !onlyPositive)

{

result+=temp+"\n";
}

temp = "";
nextNumber = false;
if (IsMinus(data[i].Key))
{
isAfterMinus = true;
}
}
}
if (temp.Length > 0 && !temp.Substring(0,1).Equals(minusStr) || !onlyPositive)
{
result += temp;
}
Console.WriteLine("Вывод: \n" + result);
}

//является ли введенный символ минусом
bool IsMinus(ConsoleKey key)
{
return(numbers[minus] == key || numbersPad[minus] == key);
}
//возвращает соответствующую символу цифру, иначе -1
int GetDigit(ConsoleKey key)
{
for (int i = 0; i< 10; i++)
{
if (numbers[i] == key || numbersPad[i] == key)
{
return i;
}
}
return -1;
}