// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


int option = ReadData("Выберите опцию\n Опция 1: Вводить координаты поочереди - нажмите 1 и ввод\n Опция 2: Вводить координаты по шаблону (x1,y1,z1);(x2,y2,z2) нажмите 2 и ввод");
int x1 = 0;
int x2 = 0;
int y1 = 0;
int y2 = 0;
int z1 = 0;
int z2 = 0;

if (option == 1)
{
    x1 = ReadData("Введите координату X1: ");
    x2 = ReadData("Введите координату X2: ");
    y1 = ReadData("Введите координату y1: ");
    y2 = ReadData("Введите координату y2: ");
    z1 = ReadData("Введите координату z1: ");
    z2 = ReadData("Введите координату z2: ");
}
else if (option == 2)
{
    string template = ReadDataByTemplate("Введите координаты по шаблону (x1,y1,z1);(x2,y2,z2) : ");
    string[] points = template.Split(";");
    string[] pointA = points[0].Trim('(',')').Split(",");
    x1 = int.Parse(pointA[0]);
    y1 = int.Parse(pointA[1]);
    z1 = int.Parse(pointA[2]);

    string[] pointB = points[1].Trim('(',')').Split(",");
    x2 = int.Parse(pointB[0]);
    y2 = int.Parse(pointB[1]);
    z2 = int.Parse(pointB[2]);  
}

double result = DistanceBetweenPoints(x1, y1, x2, y2, z1, z2);
PrintData("Расстояние между точками: ", result);




// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод находит расстояние между точками на плоскости

double DistanceBetweenPoints(double x1, double y1, double x2, double y2, double z1, double z2)
{
    double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return distance;
}

//Метод выводит данные пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}
//Метод считывает строку
string ReadDataByTemplate(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine() ?? "";
}