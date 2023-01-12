
/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да 
*/
Console.Clear();
Console.WriteLine("введите пятизначное число - ");
int number = int.Parse(Console.ReadLine());
if (number < 0)
{
    number *= -1;
}
if (number >= 10000 && number < 100000)
{
    int firstSy = number / 10000;
    int SecondSy = number / 1000 % 10;
    int FourthSy = number % 100 / 10;
    int LastSy = number % 10;
    if (firstSy == LastSy && SecondSy == FourthSy)
    {
        Console.WriteLine("Заданное число ЯВЛЯЕТСЯ палиндромом");
    }
    else
    {
        Console.WriteLine("Заданное число НЕ является палиндромом");
    }
}
else
{
    Console.WriteLine("Заданное число НЕ является пятизначным");
}