Console.Clear();
Console.Write("Введите число от 1 до 7, где 1 - понедельник :  ");
int number = int.Parse(Console.ReadLine());
if (number > 7  || number < 1)
{
    Console.WriteLine("Число не соответствует дню недели, введите число от 1 до 7");
}
else
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Сегодня выходной, поэтому отдыхаем!!!");
    }
    else
    {
        Console.WriteLine("Сегодня рабочий день! Пора трудиться!");
    }
}