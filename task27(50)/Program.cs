// Задача 50. Напишите программу, которая на вход принимает число, и возвращает 
// индексы числа в двумерном массиве или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100);
        }
        // Console.WriteLine();
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк: ");
int lines = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] matrix = new int[lines, columns];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
bool isNumberInMatrix = false;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == number)
        {
            isNumberInMatrix = true;
            break;
        }
    }
}
Console.WriteLine();

if (isNumberInMatrix = true)
{
    Console.WriteLine($"Число {number} есть в массиве");
}
else
{
    Console.WriteLine($"Числа {number} нет в массиве");
}

