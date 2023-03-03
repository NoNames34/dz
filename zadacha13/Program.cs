Console.Clear();
Console.Write("Введите число с количеством цифр не менее 3-х: ");
int Value2 = Convert.ToInt32(Console.ReadLine());
int Length2 = Value2.ToString().Length;
if (Length2 >= 3) {
	while (Value2 > 999)
	{
		Value2 = Value2 / 10;
	}
	int result = Value2 % 10;
	Console.WriteLine("Третья цифра числа " + result);
} else {
	Console.WriteLine("в числе нет ретьей цифры!");
}
