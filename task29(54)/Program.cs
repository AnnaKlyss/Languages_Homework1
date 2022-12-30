// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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
void SelectionSort(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j <  matr.GetLength(1)-1; j++)
        {
            int maxPosition = j;
            for (int k = j+1 ; k < matr.GetLength(1); k++)
            {
               if (matr[i,k] > matr[i,maxPosition]) maxPosition = k;
            }
            int temporary = matr[i,j];
            matr[i,j] = matr[i,maxPosition];
            matr[i,maxPosition] = temporary;
          }    
    }
}


int[,] matrix = new int[3, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
SelectionSort(matrix);
PrintArray(matrix);