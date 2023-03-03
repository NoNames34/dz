Console.Clear();
Console.Write("Введите численное значение дня недели: ");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day >= 1 && Day <=7) {
	if (Day >= 6) {
		Console.Write("Ура, выходной!!!");
	} else {
		Console.Write("Будний день");
	}
} else {
	Console.Write("Такого дня нет, в неделе всего 7 дней");
}