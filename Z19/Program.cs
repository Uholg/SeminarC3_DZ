//Задача 19
//Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x=ReadInt("Введите число: ");
string a = Convert.ToString(x);
 if (a.Length != 5)
{Console.Write("Необходимо ввести пятизначное число");}
else if (a[0]==a[4] && a[1]==a[3])
    {Console.Write("Число является полиндромом");}
    else {Console.Write("Число не является полиндромом");}

