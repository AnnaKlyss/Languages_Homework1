// Найти максимальное из трех чисел

Console.Write("Enter number А: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Enter number В: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Enter number C: ");
int c = int.Parse(Console.ReadLine()!);

if (a > b)
{ 
    if (a > c)
    {
     Console.Write("Max number A = ");
     Console.WriteLine(a);
    }
   else
   {
    Console.Write("Max number C = ");
    Console.WriteLine(c);
   }
}
else
{
  if (b > c)
     {
     Console.Write("Max number B = ");
     Console.WriteLine(b);
    }
   else
   {
    Console.Write("Max number C = ");
    Console.WriteLine(c);
   }
}