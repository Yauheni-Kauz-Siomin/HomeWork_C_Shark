/* Задача 50. Напишите программу, которая на вход принимает позиции
элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.Clear();
int rows = ReadInt("Введите индекс строки: ");
int columns = ReadInt("Введите индекс столбца: ");
Console.WriteLine();
int[,] numbers = new int[10, 10];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();

// проверка нахождения элемента

if (rows < numbers.GetLength(0) && columns < numbers.GetLength(1))
    Console.WriteLine(numbers[rows, columns]);
else
    Console.WriteLine($"{rows}{columns} -> Такого числа в массиве нет");

// функция формирования массива
int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
    return array;
}

// Функция для печати массива

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
}

// Функция для считывание инфы из консоли
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
