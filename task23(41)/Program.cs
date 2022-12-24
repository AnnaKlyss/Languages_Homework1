// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример:
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите числа через пробел: ");
string inputText = Console.ReadLine(); 

string[] stringArray = inputText.Split(' '); 

int[] arr = new int[stringArray.Length];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(stringArray[i]);
}

int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Пользователь ввел {count} положительных числа(чисел)");