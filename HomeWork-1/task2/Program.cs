﻿Console.Write("Введите первое число - ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число - ");
int b = int.Parse(Console.ReadLine());
int max = a;
if (b > max) max = b;
Console.WriteLine($"Наибольшее из двух чисел - {max}");