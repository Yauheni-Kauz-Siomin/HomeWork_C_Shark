/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по
убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] numbers = new int[5, 5];
FillArray(numbers);
PrintArray(numbers);
SortMaxMinArray(numbers);
PrintArray(numbers);

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

void SortMaxMinArray(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        int max = array2[0, 0];
        for (int j = 0; j < array2.GetLength(1); j++)
        {
           for (int k = 0; k < array2.GetLength(1) - 1; k++)
           {
            if (array2[i, k] < array2[i, k + 1])
            {
                int temp = array2[i, k + 1];
                array2[i, k + 1] = array2[i, k];
                array2[i, k] = temp;
            }
           }
        }
    }
}
