Console.Clear();

Console.Write("Введите порядковый номер в строке: ");
    int strok1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите порядковый номер в столбце: ");
    int stolb2 = Convert.ToInt32(Console.ReadLine()) - 1;
    int n = 5; 
    int m = 7; 
Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = random.Next(10, 99);
            Console.Write("{0} ", arr[i, j]);
            }
        Console.WriteLine();
        }
        if (strok1 < 0 | strok1 > arr.GetLength(0) - 1 | stolb2 < 0 | stolb2 > arr.GetLength(1) - 1)
    {
    Console.WriteLine("Элемент не существует  ");
    }
        else
        {
            Console.WriteLine("Значение элемента массива = {0}", arr[strok1, stolb2]);
        }
Console.ReadLine();