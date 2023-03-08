
Console.Clear();
Console.Write("Введите s1: ");
var s1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите d1: ");
var d1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите s2: ");
var s2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите d2: ");
var d2 = Convert.ToDouble(Console.ReadLine());
 
var x = -(d1 - d2) / (s1 - s2);
var y = s1 * x + d1;
 
    x = Math.Round(x, 3);
    y = Math.Round(y, 3);
 
Console.WriteLine($"Пересеклись в точке: ({x};{y})");