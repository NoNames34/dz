Console.Clear();
Console.WriteLine("Дайте 3 числа:");
            int num_a= Convert.ToInt32(Console.ReadLine());
            int num_b = Convert.ToInt32(Console.ReadLine());
            int num_c = Convert.ToInt32(Console.ReadLine());

            int max = num_a;

            if (num_b > max)
            {
                max = num_b;
            }

            if (num_c > max)
            {
                max = num_c;
            }
Console.WriteLine("Наибольшее из данных чисел = " + max);