//  Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Введите число N = ");
double n = double.Parse(Console.ReadLine()!);
Console.Write("Введите число A = ");
double a = double.Parse(Console.ReadLine()!);

if ( n % a == 0)
{ 
   Console.WriteLine("Число N кратно заданному числу А");
}
else
{
    double b =  n % a;
    Console.Write("Остаток от деления равен: ");
    Console.WriteLine(b);
}