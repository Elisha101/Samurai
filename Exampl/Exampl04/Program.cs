﻿//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число N");
int num = Convert.ToInt32(Console.ReadLine());
int index = 1;

Console.WriteLine("Четные числа от 1 до " + num);
while (index <= num)
{
      if(index % 2 == 0)
        Console.WriteLine("число четное " + index);
        index  ++;
    
}
