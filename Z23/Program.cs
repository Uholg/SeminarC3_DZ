//Задача 23
//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Введите число: ");
int count = 1;
Console.Write(" -> ");
if (number>0)
{while (count <= number)
{
    Console.Write($"{count*count*count}, ");
    count++;
}}
else 
{while (count<=-number)
{
    int s=count;
    Console.Write($"{-s*s*s} ");
    count++;
}
}


