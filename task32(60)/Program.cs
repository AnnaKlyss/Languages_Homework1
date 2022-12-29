// Задача 60. ...Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, которая 
// будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] array3d = new int[2, 2, 2];

for (int i = 0; i < array3d.GetLength(0); i++)
{
    for (int j = 0; j < array3d.GetLength(1); j++)
    {
        for (int k = 0; k < array3d.GetLength(2); k++)
        {
            array3d[i, j, k] = new Random().Next(10, 100);
        }
    }
}


for (int i = 0; i < array3d.GetLength(0); i++)
{
    for (int j = 0; j < array3d.GetLength(1); j++)
    {
        for (int k = 0; k < array3d.GetLength(2); k++)
        {
            Console.Write(array3d[i, j, k] + "(" + i + "," + j + "," + k + ")"+" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
