// Выяснить является ли число чётным

Console.Write("Введите целое число: ");
int a = int.Parse(Console.ReadLine()!);

if ( a % 2 == 0)
{ 
   Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("Нечетное число");
}
    
