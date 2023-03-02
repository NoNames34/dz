Console.Clear();
Console.Write("Введите число a: ");
var a = Decimal.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            var b = Decimal.Parse(Console.ReadLine());
            if (a > b)
                Console.WriteLine(a);
            else 
                Console.WriteLine(b);
