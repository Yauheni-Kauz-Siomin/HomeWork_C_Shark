/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

/* Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < b; i++)
{
    result = result * a;

}
Console.WriteLine($"Число {a} в степени {b} равняется {result}"); */

// решение задачи без использования функции


Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {a} в степени {b} равняется {Result(a, b)}");

int Result(int num1, int num2)
{
    int result = 1;
    for (int i = 0; i < num2; i++)
    {
        result = result * num1;
    }
    return result;
}
/*  решение задачи с использованием функции, при таком решении проверка 
на равенство нулю или при вводе отрицательных чисел не нужна, все итак работает корректно */

