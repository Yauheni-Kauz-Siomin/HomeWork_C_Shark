/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */


Console.Clear();
int[] sumEven = CreateArray();
Console.WriteLine($"[{String.Join(", ", sumEven)}]");
Console.WriteLine($"Количество чётных чисел в массиве составляет {SchowSumEvenNumbers(sumEven)}");



int[] CreateArray()
{
    Console.WriteLine("Введите количество элементов массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int SchowSumEvenNumbers(int[] arr)
{
    int sumEvenNumber = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) sumEvenNumber++;
    }
    return sumEvenNumber;
}

// решение метода SchowSumEvenNumbers с использованием операто foreach
/* int SchowSumEvenNumbers(int[] arr)
{
    int sumEvenNumber = 0;
    foreach (var item in arr)
    {
        if (item % 2 == 0) sumEvenNumber++;
    }
    return sumEvenNumber;
} */