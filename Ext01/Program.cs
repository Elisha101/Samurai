// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да



// Console.WriteLine("Введите число: ");
// string num = Console.ReadLine();
// int rust = num.Length;

// if (rust == 5)
// {
//     if (num[0] == num[4] && num[1] == num[3])
//     {
//         Console.WriteLine($"{num} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{num} - Не палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"Что-то, тут не так : {num} - не является пятизначным числом");
// }


Console.WriteLine("Введите 5-ое число: ");
int num = int.Parse(Console.ReadLine()!);
void ChakNum()
{
    int num1 = num / 10000 % 10;
    int num2 = num / 1000 % 10;
    int res1 = num / 10 % 10;
    int res2 = num % 10;
    int nuk = num / 10000;

    if (nuk < 1 || nuk > 9)
    {
        Console.WriteLine("Введено не 5-ое число");
    }
    else if (num1 == res2 && num2 == res1)
    {
        Console.WriteLine("Число является Палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндрамом");
    }
}
ChakNum();