Console.Clear();
Console.WriteLine("Проверяем чётность. Введите число: ");
           int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 1)
            {
                Console.WriteLine("Число " + num + " : нечётное");
            }
            else
            {
                Console.WriteLine("Число " + num + " : чётное");
            }