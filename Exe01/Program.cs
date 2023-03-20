// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трех значное число");
int num = Convert.ToInt32(Console.ReadLine());
int length = num.ToString().Length;
int result = 0;

if (length == 3)
{
    result = num % 100 / 10;
    Console.WriteLine(result); 
}
else Console.WriteLine("Пожалуйста введите 3 числа!");

