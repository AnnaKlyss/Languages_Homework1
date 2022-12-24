// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12

// Console.WriteLine("Введите число: ");
// string str = Console.ReadLine();
// int sum = 0;

// for (int i = 0; i < str.Length; i++)
// {
//     char currentChar = str[i]; // '1'
//     // для примера пытаемся получить число сразу из символа
//     int positionOfChar = Convert.ToInt32(currentChar); // 49 - порядковый номер '1' в таблице ascii
//     // символ currentChar приводим к строке (меняем тип данных на string)
//     string stringChar = currentChar.ToString(); // "1"
//     int numberFromChar = int.Parse(stringChar); // число 1
//     Console.Write($"Сивол: {currentChar}, позиция: {positionOfChar}, число: {numberFromChar} \n");
// }

// for (int i = 0; i < str.Length; i++)
// {
//     int currentNumber = int.Parse(str[i].ToString());
//     sum += currentNumber; // sum = sum + currentNumber
// }
// Console.WriteLine(sum);

// // Правила по стилю написания кода (code style)
// // Все названия любых структур языка должны описывать то, что они делают или хранят
// // Переменные: первое слово пишется с маленькой буквы, следующие слова с большой
// string textFromConsole; // Текст из консоли
// string text; // вот так не надо, это не информативно

// // Функции (Класс, интерфейсы, структуры, перечисления): Все слова с первого пишутся с большой буквы
// int GetRandomNumber(int from, int to) // Получение случайного числа
// {
//     return 0; // заглушка
// }

// Заполение массива:
// int[] array = {new Random().Next(0, 10)}; // так не сработает, будет только одно число
// int[] array = new int[4]; // 4 - размер (количество)

// for (int i = 0; i < array.Length; i++) // заполнение массива
// {
//     int randomNumber = new Random().Next(0, 10); // генерируем случайное число
//     array[i] = randomNumber; // кладём в массив на место с индексом i
// }

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();

// for (int i = 0; i < array.Length; i++) // изменение массива уже после заполнения
// {
//     array[i] = array[i] + 5;
// }

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }

// Задать массив с клавиатуры

// Console.WriteLine("Введите числа через пробел: ");
// string inputText = Console.ReadLine(); // "4 5 2"

// string[] stringArray = inputText.Split(' '); // ["4", "5", "2"]

// int[] arr = new int[stringArray.Length];

// for (int i = 0; i < arr.Length; i++)
// {
// arr[i] = int.Parse(stringArray[i]);
// }

// for (int i = 0; i < arr.Length; i++)
// {
// Console.Write(arr[i] + " ");
// }