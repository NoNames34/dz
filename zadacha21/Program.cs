Console.Clear();
    int x1 = Coordinate("x", "C");
    int y1 = Coordinate("y" , "C");
    int z1 = Coordinate("z" , "C");
    int x2 = Coordinate("x", "D");
    int y2 = Coordinate("y", "D");
    int z2 = Coordinate("z", "D");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine ());
}
double Decision (double x1, double x2, double y1, double y2, double z1, double z2){
    return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2 -y1, 2) + Math.Pow(z2-z1, 2));
}
double segmentLength = Math.Round(Decision (x1, x2, y1, y2, z1, z2),2);
Console.WriteLine($"Расстояние между точками равно {segmentLength}");