// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandonNumbers(numbers);
Console.WriteLine("В этом массиве: ");
PrintArray(numbers);

void RandonNumbers(int[] numbers)
{
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}


int count = 0;

for (int x = 0; x < numbers.Length; x++)
{
    if (numbers[x] % 2 == 0)
        count++;
}
Console.WriteLine($"из {numbers.Length} чисел, {count} четных");


void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

// Console.Write("Введите длинну массива: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] randomArray = new int[a];

// void mas(int a)
// {
//     for (int i = 0; i < a; i++)
//     {
//         randomArray[i] = new Random().Next(99, 999);
//         Console.Write(randomArray[i] + " ");
//     }

// }

// int kol(int[] randomArray)
// {
//     int kol = 0;
//     for (int i = 0; i < randomArray.Length; i++)
//     {
//         if (randomArray[i] % 2 == 0)
//             kol = kol + 1;
//     }
//     return kol;
// }

// mas(a);
// Console.Write($"Количество чётных чисел в массиве: {kol (randomArray)}");