﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("Введите значениe N: ");
double N = double.Parse(Console.ReadLine()!);

double i = 1;
do
{
    double y = Math.Pow(i, 3);
    Console.Write(y + ", ");
    i++;
} while (i <= N);