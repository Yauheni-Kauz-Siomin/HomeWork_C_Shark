/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.Clear();
Console.WriteLine("Введите несколько чисел через пробел или запятую:");
int[] numbers = Console.ReadLine().Split(' ', ',').Select(e => Convert.ToInt32(e)).ToArray(); // способ перевода был на лекции
// Console.WriteLine(String.Join(" ", numbers)); проверка выводится ли массив уже из чисел
Console.WriteLine($"Количество введенных пользователем положительных чисел составляет {SumPositiveNumbers(numbers)}");


int SumPositiveNumbers(int[] array)
{
    int sum = 0;
    foreach (int item in array)
    {
        if(item > 0) sum++;
    }
    return sum;

}


