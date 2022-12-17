// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число В: ");
int b = int.Parse(Console.ReadLine()!);
int c = b*b;
if (a == c)
{ 
   Console.WriteLine("Число А является квадратом числа В");
}   
else
{
    Console.WriteLine("Число А не является квадратом числа В");
}