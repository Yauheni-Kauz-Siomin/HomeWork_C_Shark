/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();
int M = ReadInt("Введите первое число M: ");
int N = ReadInt("Введите второе число N: ");
int sumMN = SumNumbers(M, N);
Console.WriteLine($"Cумма натуральных элементов в промежутке от M до N -> {sumMN}");

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int start, int end)
{
    int sum = start;
    if (end == start)
    {
        return sum;
    }
    sum += SumNumbers(start + 1, end);
    return sum;
}
