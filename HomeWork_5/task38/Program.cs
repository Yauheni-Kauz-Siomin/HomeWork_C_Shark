/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.Clear();
int[] maxMin = CreateArray();
Console.WriteLine($"[{String.Join(", ", maxMin)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {MaxNamber(maxMin) - MinNamber(maxMin)}");

int[] CreateArray()
{
    Console.WriteLine("Введите количество элементов массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

int MaxNamber(int[] arr)

{
    int numberMax = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > numberMax) numberMax = arr[i];
    }
    return numberMax;
}

int MinNamber(int[] arr)

{
    int numberMin = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < numberMin) numberMin = arr[i];
    }
    return numberMin;
}