﻿//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите положительное целое число: ");
int a = int.Parse(Console.ReadLine()!);

if (a <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    if (a >= 1000)
    {
        while (a >= 1000)
        {
            a = a / 10;     // Я не поняла, почему программа ругается если я пишу тут int a. Объясниете, пожалуйста.
        }
        int b = a % 10;
        Console.Write("Третья цифра: ");
        Console.WriteLine(b);
    }
    else
    {
        int b = a % 10;
        Console.Write("Третья цифра: ");
        Console.WriteLine(b);
    }

}