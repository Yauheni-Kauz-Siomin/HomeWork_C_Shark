/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

Console.Clear();
Console.WriteLine($"Вывовд массива, состоящего из 8-ми случайных элементов, выглядит следующим образом [{String.Join(", ", CreateArray())}]");
Console.WriteLine();

int[] CreateArray()
{
    int size = 8;
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
// решение задачи с выводом массива через метод String.Join, предложенный на практическом занятии;


CreateArray();
Console.Write($"Вывовд массива, состоящего из 8-ми случайных элементов, выглядит следующим образом:");
PrintArray(CreateArray1());

int[] CreateArray1()
{
    int size = 8;
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i] + " ");
    }
}
// решение массива с двумя методами : один на создание массива, другой печатет массив;