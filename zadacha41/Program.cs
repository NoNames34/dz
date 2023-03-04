Console.Clear();
Console.Write("Укажите несколько чисел через пробел: ");
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int count = arr.Count(x => x > 0);
Console.WriteLine($"Кол-во чисел больше нуля: {count}");