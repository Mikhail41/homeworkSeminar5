//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
Console.WriteLine("Эта программа задаёт массив заполненный случайными положительными трёхзначными числами и показывает количество чётных чисел в массиве. ");
Console.WriteLine();
int n = new Random().Next(1, 10);
Console.WriteLine($"Размерность массива =: " + n);

int[] fillArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
int[] arr = new int[n];

fillArr(arr);
PrintArray(arr);
Console.WriteLine();
int evenNumbers(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            quantity++;
        }
    }
    return quantity;
}

int quantity = evenNumbers(arr);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве =: {quantity}");