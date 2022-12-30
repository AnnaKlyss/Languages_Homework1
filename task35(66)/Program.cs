// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите значениe m, где m < n: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите значениe n, где n > m: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumNumbers(m, n));

int SumNumbers(int start, int end)
{
    if (start == end) return end;
    return (start + SumNumbers(start + 1, end));
}
