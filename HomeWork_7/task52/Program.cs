/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Clear();
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
Console.WriteLine();
int[,] numbers = new int[rows, columns];
FillArray(numbers);
PrintArray(numbers);

// среднее арифметическое столбцов
double[] avgNumbersColumns = new double[numbers.GetLength(1)];

for (int i = 0; i < numbers.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        result += numbers[j, i];
    }
    avgNumbersColumns[i] = result / numbers.GetLength(0);
}
Console.WriteLine($"[{String.Join(", ", avgNumbersColumns)}]");


// ввод инфы с консоли
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// формирование массива
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}
// печать массива
void PrintArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(0); j++)
        {
            Console.Write(array1[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



