// : Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[10];

for (int i = 0; i < array.Length; i++)
{
    double randomNumber = new Random().Next(-100, 101);
    array[i] = randomNumber;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
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
Console.WriteLine("Минимальное число " +  minPosition + " максимальное  число " + maxPosition);

Console.WriteLine("Разница между максимальным и минимальным элементами массива " + (maxPosition-minPosition));

