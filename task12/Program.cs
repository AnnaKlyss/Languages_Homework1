//  Напишите программу, которая принимает на вход цифру, обозначающую 
//  день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter any number from 1 to 7 : ");
int number = int.Parse(Console.ReadLine()!);

if (number <= 5)
{
   Console.Write("No");
}
else
{
    Console.Write("Yes");
}