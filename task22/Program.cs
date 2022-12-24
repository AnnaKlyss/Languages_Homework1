// Доп.Задача Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    int randomNumber = new Random().Next(-10, 11);
    array[i] = randomNumber;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int newArrayLength = 1;

if (array.Length % 2 == 0)
{
   newArrayLength = array.Length/2;
}
else
{
    newArrayLength = array.Length/2 + 1;
}

int[] newArray = new int[newArrayLength];

for (int i = 0; i < array.Length/2; i++)
{
    newArray[i] = array[i] * array[array.Length-1-i];

    if (array.Length % 2 == 0)
    {
        Console.Write(" ");
    }
    else
    {
        newArray[newArrayLength-1] = array[array.Length/2 + 1];
    }
    Console.Write(newArray[i] + " ");
}

Console.WriteLine();
