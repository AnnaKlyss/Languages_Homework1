// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.Write("Введите значение х1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение z1: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение х2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение y2: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение z2: ");
int z2 = int.Parse(Console.ReadLine()!);

double XY = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2) );
Console.Write("Расстояние между двумя точками: " + XY);