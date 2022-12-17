// По заданному номеру дня недели вывести его название

Console.Write("Enter any number from 1 to 7 : ");
int number = int.Parse(Console.ReadLine()!);

if (number == 1)
{
   Console.Write("Monday");
}
if (number == 2)
{
   Console.Write("Tuesday");
}
if (number == 3)
{
    Console.Write("Wednesday");
}
if (number == 4)
{
    Console.Write("Thursday");
}
if (number == 5)
{
    Console.Write("Friday");
}
if (number == 6)
{
    Console.Write("Saturday");
}
if (number == 7)
{
    Console.Write("Sunday");
}