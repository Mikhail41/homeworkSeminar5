//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
Console.WriteLine("Эта программа задаёт одномерный массив, заполненный случайными числами и находит сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine();

int n = new Random().Next(3, 12);
Console.WriteLine($"Размерность массива =: " + n);

int[] fillArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-99, 100);
    }
    return arr;
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
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
int sumElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + arr[i];
        }

    }
    return sum;
}

int quantity = sumElements(arr);
Console.WriteLine();
Console.WriteLine($"Сумма нечетных элементов =: {quantity}");
Console.WriteLine();