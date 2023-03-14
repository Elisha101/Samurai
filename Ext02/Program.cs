// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = ReadInt("Введите координату X первой точки: "),
    q1 = ReadInt("Введите координату Q первой точки: "),
    v1 = ReadInt("Введите координату V первой точки: "),
    x2 = ReadInt("Введите координату X второй точки: "),
    q2 = ReadInt("Введите координату Q второй точки: "),
    v2 = ReadInt("Введите координату V второй точки: ");


int A = x2 - x1, B = q2 - q1 , C = v2 - v1;

double perfect = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Расстояние: {perfect}");



int ReadInt(string simp)
{
    Console.Write(simp);
    return Convert.ToInt32(Console.ReadLine());
}
