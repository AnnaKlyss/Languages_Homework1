
// Пример настоящей программы
using System;

namespace GB.Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 5;
            int square = number * number;
            Console.WriteLine(square);
        }
    }
}


// Конец примера настоящей программы


// // DRY - don't repeat yourself - не повторяйся 
// (повторяющиеся код или действия выносить в методы или циклы)

// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write(arr[i] + " ");
// }

// // Делаем какие-то операции

// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write(arr[i] + " ");
// }
// // Вывод по DRY: если у нас два раза нужно вывести массив, то лучше сделать метод на вывод массива и вызывать его два раза

// // KISS - keep it simple - сделай это проще (не усложнять код)

// if (arr[0] / 2 * 2 == 0) // вместо (arr[0] % 2 == 0)
// {
//     Console.WriteLine("Чётное");
// }
// // Вывод по KISS: если можно не усложнять, то не надо усложнять.
// // Чаще всего есть уже более понятные и простые решения, нужно их погуглить

// // YAGNI - you ain't gonna need it - тебе это не понадобится (не делать сущностей сверх необходимого)

// void Print(string str)
// {
//     Console.WriteLine(str);
// }
// // Вывод по YAGNI: не создавать лишних методов. если в задаче используется только целочисленный массив,
// // то не стоит заранее писать методы на вывод в консоль массивов с другими типами данных


// // SOLID: S - принцип единственности ответственности
// // Метод, класс или другая сущность должны выполнять только одну функцию

// int[] FillArray(int[] array)
// {
//     // как-то заполняем массив
//     return array;
// }

// void PrintArray(int[] array)
// {
//     // вывод массива
// }
// // Вывод по SOLID, буква S: каждый метод выполняет одну задачу. Не смешивать заполнение массива и его вывод в консоль

// // Правила написания кода (code style)
// // Названия переменных: первое слово с маленькой буквы, остальные с большой, нет подчёркиваний и тире
// int number;
// int numberOfSomething;

// // Названия методов: все слова с большой буквы (осмысленное название)
// void GetNumber(int[] array){}


















// Рекурсия - вызов функции изнутри этой же функции

// функция GetNumber


/// <summary>
/// фывфывфывфывфывфыв
/// </summary>
// int GetNumber()
// {
//     Console.WriteLine("Введите число");
//     string text = Console.ReadLine();

//     if (!int.TryParse(text, out int number))
//     {
//         Console.WriteLine("Введите именно число");
//         // вызываем внутри функции GetNumber функции GetNumber
//         return GetNumber();
//     }

//     return number;
// }

// int number = GetNumber();
// Console.WriteLine($"Получилось число: {number}");


// int[,] SortArr(int[,] ar)
// {
//     int min = ar[0, 0];
//     int minI = 0;
//     int minJ = 0;

//     for (int i = 0; i < ar.GetLength(0); i++)
//     {
//         for (int j = 0; j < ar.GetLength(1); j++)
//         {
//             if (min > ar[i, j])
//             {
//                 min = ar[i, j];
//                 minI = i;
//                 minJ = j;
//             }
//         }
//     }
//     int[,] res = new int[ar.GetLength(0) - 1, ar.GetLength(1) - 1];
//     for (int i = 0; i < ar.GetLength(0); i++)
//     {
//         if (i == minI)
//         {
//             continue;
//         }
//         for (int j = 0; j < ar.GetLength(1); j++)
//         {
//             if (j == minJ)
//             {
//                 continue;
//             }

//             Console.Write(ar[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     return ar;
// }


// фишки циклов

// continue -- пропуск итерации и переход к следующей
// for (int i = 0; i < 5; i++)
// {
//     if (i == 3)
//     {
//         continue;
//     }
//     Console.WriteLine(i);
// }

// break -- остановка цикла
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 5; j++) 
//     { 
//         if (i == 0 && j == 3)
//         {
//             break;
//         }
//         Console.WriteLine($"{i}, {j}");
//     }
// }