//  Задача 29 Напишите программу, которая задаёт 
// массив из N элементов и выводит их на экран.
// 5 -> [1, 2, 5, 7, 19]; 3 -> [6, 1, 33] 

int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArr = new int[lenArray];
for (int i = 0; i < randomArr.Length; i++)
{
    randomArr[i] = new Random().Next(1,9);
    Console.Write(randomArr[i] + " ");
}


int ReadInt(string mass)
{
    Console.Write(mass);
    return Convert.ToInt32(Console.ReadLine());
}