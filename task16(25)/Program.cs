// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Не используя Math.Pow!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите значение A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение B: ");
int b = int.Parse(Console.ReadLine()!);

if (b < 0)
{
    b = b * (-1);
}
int result = 1;
for (int i = 1; i <= b; i++)
{
    result = result * a;
}
Console.WriteLine("Число " + a + " в степени " + b + " равно " + result);
