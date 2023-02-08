/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая
будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов
в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


int[,] numbers = new int[4, 4];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine(
    $"Номер строки с наименьшей суммой элементов: {MinSumNumbersRow(numbers)} строка"
);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write(array1[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int MinSumNumbersRow(int[,] array2)
{
    int row = 0;
    int minSum = 0;

    for (int i = 0; i < array2.GetLength(1); i++)
    {
        minSum += array2[0, i];
    }

    for (int i = 0; i < array2.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            sum += array2[i, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            row = i;
        }
    }
    return row;
}
