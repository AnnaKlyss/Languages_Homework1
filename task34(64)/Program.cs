// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа
//  в промежутке от N до 1. Выполнить с помощью рекурсии.

// Console.Write("Введите значениe n: ");
// int n = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumbers(n));

// string PrintNumbers(int number)
// {
//     if (number == 1) return "1";
//     return (number + " " + PrintNumbers(number-1));
// }


//  Шпаргалка по рекурсии, семинар 9 C#:

//Задайте значение N. Напишите программу,
//которая выведет все натуральные числа в промежутке от 1 до N.

// Console.Clear();
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine(PrintNumbers(1, n));

// string PrintNumbers(int start, int end)
// {
// if (start == end) return end.ToString();
// return (start + " " + PrintNumbers(start + 1, end)); // "3 2 1"
// }


// Задача 2: Задайте значение N. Напишите программу, которая найдёт сумму натуральных элементов
//  в промежутке от 1 до N.


Console.Write("Введите значениe m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите значениe n: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumNumbers(m, n));

int SumNumbers(int start, int end)
{
    if (start == end) return end;
    return (start + SumNumbers(start + 1, end));
}
