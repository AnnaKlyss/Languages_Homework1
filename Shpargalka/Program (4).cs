// Циклы:
// Прерывание - break

// Console.WriteLine("Начало цикла");
// for (int i = 0; i < 10; i++)
// {
//     if (i == 2)
//     {
//         Console.WriteLine($"{i} это уже и так много");
//         break; // прерывание цикла и выход из него
//     }
//     Console.WriteLine(i);
// }
// Console.WriteLine("Конец цикла");

// Переход к следущей итерации - continue
// Console.WriteLine("Начало цикла");
// for (int i = 0; i < 4; i++)
// {
//     if (i == 2)
//     {
//         Console.WriteLine($"Мне не нравится квадрат {i}");
//         continue;
//     }
//     Console.WriteLine(i * i);
// }
// Console.WriteLine("Конец цикла");

// Двумерные массивы:
// определение
// int[,] arr = new int[2,3] // [количество строк, количество столбцов]
// {
//     {1, 2, 3}, // [2,3] - [количество одномерных массивов, длина каждого одномерного массива]
//     {2, 3, 4}
// };
// // или
// int[,] arr = 
// {
//     {1, 2, 3},
//     {2, 3, 4}
// };
// // или
// int[,] arr = new int[2,3];

// Получение длин массива:
// количество элементов (всего)
// int[,] arr = new int[2,3] // [количество строк, количество столбцов]
// {
//     {1, 2, 3},
//     {2, 3, 4}
// };
// int arrayLength = arr.Length;
// Console.Write(arrayLength); // 6

// // количество строк
// int linesCount = arr.GetLength(0);
// Console.Write(linesCount); // 2

// // количество столбцов
// int columnsCount = arr.GetLength(1);
// Console.Write(columnsCount); // 3

// Заполнение двумерного массива:
// int[,] arr = new int[2, 3];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = new Random().Next(0, 10);
//     }
// }

// // Вывод двумерного массива
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();
// Console.WriteLine(arr[0, 0]);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] array = new double[5];
// for (int i = 0; i < array.Length; i++)
// {
//     double number = new Random().Next(0, 10) + new Random().NextDouble(); // 8 + 0.22 = 8.22
//     array[i] = Math.Round(number, 2); // округление числа: Math.Round(число для округления, количество знаков)
// }
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }

// // При таком варианте мы никогда не ошибёмся с диапазоном массива, потому что первое число массива
// // есть в массиве, а остальные либо меньше, либо больше, либо равны ему
// double min = array[0];
// double max = array[0];

// Задача 3: Задайте массив из 8 случайных чисел. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// int[] FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// bool IsNumberInArray(int number, int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// int[] array = new int[8];
// array = FillArray(array);
// PrintArray(array);
// Console.WriteLine("\n Введите \n число: ");
// int number = int.Parse(Console.ReadLine());
// // bool isNumberInArray = IsNumberInArray(number, array);
// bool isInArray = false;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == number)
//     {
//         isInArray = true;
//         break;
//     }
// }
// // // Все операции сравнения и равенства - bool
// // // 5 > 8 -- тоже bool
// if (isInArray)
// {
//     Console.WriteLine($"Число {number} есть в массиве");
// }
// else
// {
//     Console.WriteLine($"Числа {number} нет в массиве");
// }

// Вывод массива с клавиатуры:
// :

// Console.WriteLine("Введите числа через пробел: ");
// string inputText = Console.ReadLine(); // "4 5 2"

// string[] stringArray = inputText.Split(' '); // ["4", "5", "2"]

// int[] arr = new int[stringArray.Length];

// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = int.Parse(stringArray[i]);
// }

// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write(arr[i] + " ");
// }