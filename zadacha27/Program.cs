Console.Clear();
Console.WriteLine("Введите число: ");
    int i = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
while (i > 0)
    {
    int num = i % 10;
    i = i / 10;
    sum = sum + num;
    }
Console.WriteLine($"Cумма цифр в указанном числе: " + sum);