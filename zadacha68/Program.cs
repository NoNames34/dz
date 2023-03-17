Console.Clear();

Console.WriteLine("Введите начальное число c:");
int numberC = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число d:");
int numberD = int.Parse(Console.ReadLine());

int AckermannFunction (int numberC, int numberD)
    {
        if (numberC == 0) return numberD + 1;
        if (numberC != 0 && numberD == 0) return AckermannFunction(numberC - 1, 1);
        if (numberC > 0 && numberD > 0) return AckermannFunction(numberC - 1, AckermannFunction(numberC, numberD - 1));
    return AckermannFunction(numberM, numberD);
    }

Console.WriteLine($"Функция Аккермана для чисел A({numberC},{numberD}) = {AckermannFunction(numberC, numberD)}");