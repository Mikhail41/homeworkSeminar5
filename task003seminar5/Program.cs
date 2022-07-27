//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
Console.WriteLine("Эта программа задаёт массив вещественных чисел и находит разницу между максимальным и минимальным элементов массива.");
Console.WriteLine();

int n = new Random().Next(3, 12);
Console.WriteLine($"Размерность массива =: " + n);

double[] fillArr(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-99, 100);
    }

    return arr;
}
void PrintArray(double[] array)
{
    Console.Write("[ ");
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
double[] arr = new double[n];

fillArr(arr);
PrintArray(arr);
Console.WriteLine();

double maxNumber = arr[0];
double minNumber = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (maxNumber < arr[i])
    {
        maxNumber = arr[i];
    }
    if (minNumber > arr[i])
    {
        minNumber = arr[i];
    }
}

double difference = maxNumber - minNumber;
Console.WriteLine();
Console.WriteLine($"разница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {difference}");
Console.WriteLine();

