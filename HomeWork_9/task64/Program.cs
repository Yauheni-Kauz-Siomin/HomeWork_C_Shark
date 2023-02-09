/* Задача 64: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Clear();
int N = ReadInt("Введите натуральное число N:");
Console.Write($"N = {N} -> ");
DecreasingNumbers(N, 1);

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void DecreasingNumbers(int start, int end)
{
    Console.Write($"{start} ");
    if (start == end)
        return;
    DecreasingNumbers(start - 1, end);
}
