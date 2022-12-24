// Доп.Задача Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-9, 9);
        index++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write(coll[pos] + " ");
        pos++;
    }

}
int[] array = new int[9];
FillArray(array);
PrintArray(array);
Console.WriteLine(" ");


int newArrayLength = 1;

if (array.Length%2 == 0)
{
   newArrayLength = (array.Length/2);
}
else
{
    newArrayLength = (array.Length/2 + 1);
}

int[] newArray = new int[newArrayLength];

for (int i = 0; i < array.Length/2; i++)
{
    newArray[i] = array[i] * array[array.Length-1-i];

    Console.Write(newArray[i] + " ");
}
if (array.Length%2 != 0)
    {
        newArray[newArrayLength-1] = array[array.Length/2];
        Console.Write(newArray[newArrayLength-1]);
    }

Console.WriteLine();
