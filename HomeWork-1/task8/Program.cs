Console.Clear();
Console.Write("Введите число - ");
int n = int.Parse(Console.ReadLine());
if (n < 0)
{
    int i = -1;
    while (i >= n)
    {
        if (i % 2 == 0)
        {
            Console.Write($" {i}");
        }
        i--;
    }
}
else
{
    int i = 1;
    while (i <= n)
    {
        if (i % 2 == 0)
        {
            Console.Write($" {i}");
        }
        i++;
    }
}