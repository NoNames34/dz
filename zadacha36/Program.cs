Console.Clear();
Console.WriteLine("Укажите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
        Console.WriteLine("Случайный массив: ");
        PrintArray(numbers);
        int sum = 0;

        for (int z = 0; z < numbers.Length; z+=2)
            sum = sum + numbers[z];

            Console.WriteLine($"получилось {numbers.Length} чисел. Сумма чисел на нечётных позициях = {sum}");

        void FillArrayRandomNumbers(int[] numbers)
            {
                for(int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = new Random().Next(1,10);
                    }
            }
            void PrintArray(int[] numbers)
            {
                Console.Write("[ ");
                for(int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                Console.Write("]");
                Console.WriteLine();
            }