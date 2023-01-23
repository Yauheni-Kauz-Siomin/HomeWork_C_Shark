/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
 стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Clear();
int[] sumOddElement = CreateArray();
Console.WriteLine($"[{String.Join(", ", sumOddElement)}]");
Console.WriteLine($"Сумма элементов,стоящих на нечётных позициях равная {SumNumbersOddIndex(sumOddElement)}");



int[] CreateArray()
{
    Console.WriteLine("Введите количество элементов массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

int SumNumbersOddIndex(int[] arr)

{
    int sumElement = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) sumElement = sumElement + arr[i];
    }
    return sumElement;
}