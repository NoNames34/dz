Console.Clear();
Console.Write("Введите трёхзначное число: ");
int Value = Convert.ToInt32(Console.ReadLine());
int Length = Value.ToString().Length;
if (Length == 3) {
	int result = ( Value/10 ) % 10;
	Console.WriteLine("Вторая цифра данного числа " + result);
} else {
	Console.WriteLine("Число не трёхзначное!");
}