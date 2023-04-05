// ?Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// ?N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


//TODO Console.Write("Введите натуральное число больше 1: ");
// int number = Convert.ToInt32(Console.ReadLine());


// void NumberCounter (int number)
// {
//     if (number < 0) Console.Write($"{number} не натуральное число");
//     if (number == 0) return;
//     Console.Write("{0,2}" + ",", number);
//     NumberCounter (number - 1);
// }

//TODO NumberCounter(number);



// ?Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// ?M = 4; N = 8. -> 30

// TODO Console.WriteLine("Введите начальное число M:");
// int numberM = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите начальное число M:");
// int numberN = Convert.ToInt32(Console.ReadLine());


// void GapNumberSum (int numberM, int numberN, int sum)
// {
//     if (numberM > numberN) 
//     {
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
//         return;
//     }
//     sum = sum + (numberM++);
//     GapNumberSum(numberM, numberN, sum);
// }

// TODO GapNumberSum(numberM, numberN, 0);



//? Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
//? m = 3, n = 2 -> A(m,n) = 29


//TODO Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanFunction(m,n);


// void AkkermanFunction(int m, int n)
// {
//     Console.Write(Akkerman(m, n)); 
// }


// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
//TODO }