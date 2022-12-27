// Доп. задача Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Пример:
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.Write("Введите значение N: ");
int number10 = int.Parse(Console.ReadLine()!);

int count = 0;

while (number10 > 0)
{
    int a = number10 % 2;
    number10 = number10 / 2;
    Console.Write(a);
    count++;
}
Console.WriteLine();
Console.WriteLine(count);
int[] array = new int[count]; 

for (int i = 0; i < count; i++) 
{
    int randomNumber = new Random().Next(-100, 101); 
    array[i] = randomNumber; 
}


// я понимаю, что полученное число не одно, а целый набор. 
// Как слепить из них одно надеюсь узнать на семинаре =)