// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да



Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int rust = num.Length;

if (rust == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"{num} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{num} - Не палиндром");
    }
}
else
{
    Console.WriteLine($"Что-то, тут не так : {num} - не является пятизначным числом");
}

