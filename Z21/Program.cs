//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x1=ReadInt("Введите координату X первой точки: ");
int y1=ReadInt("Введите координату Y первой точки: ");
int z1=ReadInt("Введите координату Z первой точки: ");
int x2=ReadInt("Введите координату X второй точки: ");
int y2=ReadInt("Введите координату Y второй точки: ");
int z2=ReadInt("Введите координату Z второй точки: ");

Console.WriteLine($"Координаты первой точки: {x1}, {y1}, {z1}");
Console.WriteLine($"Координаты первой точки: {x2}, {y2}, {z2}");

int a = x2-x1;
int b = y2-y1;
int c = z2-z1;
double result=Math.Sqrt(a*a + b*b + c*c);

Console.WriteLine($"Расстояние между точками = {result}");

