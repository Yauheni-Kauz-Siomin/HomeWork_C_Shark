Console.Clear();
int number = new Random().Next(100,1000);
Console.WriteLine($"Сгенерированное число - {number}");
Console.WriteLine($"Вторая цифра сгенерированного числа - {number/10%10}");
