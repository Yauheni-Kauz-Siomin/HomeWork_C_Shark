﻿/* Задача 68: Напишите программу вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Clear();
int m = ReadInt("Введите первое НЕ отрицательно число m:");
int n = ReadInt("Введите второе НЕ отрицательно число n:");
int functionAkkerman = Akk(m, n);
Console.WriteLine($"Функция Аккермана -> {functionAkkerman} ");

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Akk(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Akk(m - 1, 1);
    else
        return Akk(m - 1, Akk(m, n - 1));
}
