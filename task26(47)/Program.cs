// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами от -10,0 до 10,0.
// m = 3, n = 4.
// 0,5 7,0 -2,0 -0,2
// 1,0 -3,3 8,0 -9,9
// 8,0 7,8 -7,1 9,0

void PrintArray(double[,] matr)
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

double[,] array = new double[lines, columns];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double randomNumber = new Random().Next(-9, 10) + new Random().NextDouble();
        array[i, j] = Math.Round(randomNumber, 1);
    }

}

Console.WriteLine();
PrintArray(array);

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (i % 2 == 0 && j % 2 == 0)
//         {
//             double x = Math.Pow(matrix[i, j], 2); // получение квадрата с типом данных dobule
//             matrix[i, j] = Convert.ToInt32(x); // изменение типа данных с double на int
//         }
//     }
// }
// Console.WriteLine();
// PrintArray(matrix);
