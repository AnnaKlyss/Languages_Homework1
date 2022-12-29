// Задайте два двумерных массива (от 0 до 10). Напишите программу, которая будет находить произведение 
// двух массивов (поэлементное).Например, даны 2 массива:
// 2 4
// 3 2

// 3 4
// 3 3
// Результирующая матрица будет:
// 6 16
// 9 6


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 11);
        }
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

int[,] matrix1 = new int[2, 2];
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();

int[,] matrix2 = new int[2, 2];
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();


int[,] resultMatrix = new int[2, 2];

for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        resultMatrix[i, j] = matrix1[i,j] * matrix2[i, j];
    }
}
PrintArray(resultMatrix);