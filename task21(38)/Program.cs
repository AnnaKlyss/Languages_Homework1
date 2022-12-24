// : Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[10];

for (int i = 0; i < array.Length; i++)
{
    double randomNumber = new Random().Next(-100, 101) + new Random().NextDouble(); // добавили дробное NextDouble генерирует от 0 до 1
    array[i] = Math.Round(randomNumber, 2);  // округление до сотых
}

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i] + " ");
}
Console.WriteLine();

double minPosition = 0;
double maxPosition = 0;

for (int i = 0; i < array.Length; i++)
{
    if (minPosition > array[i])
    {
        minPosition = array[i];
    }
    if (maxPosition < array[i])
    {
        maxPosition = array[i];
    }
}
Console.WriteLine("Минимальное число " + minPosition + " максимальное  число " + maxPosition);

Console.WriteLine("Разница между максимальным и минимальным элементами массива " + (maxPosition - minPosition));

