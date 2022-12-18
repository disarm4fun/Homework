Console.WriteLine("Введите b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2");
double k2 = double.Parse(Console.ReadLine()!);

if (k1 != k2)
{
    double findX = Math.Round(FuncX(b1, k1, b1, b2), 2);
    double findY = Math.Round(FuncY(findX, b1, k1), 2);
    Console.WriteLine($"{findX}; {findY}");
}
else Console.WriteLine($"Прямые не пересекатются");

double FuncX(double c1, double a1, double c2, double a2)
{
    double x;
    if (a1 > a2) x = (c2 - c1) / (a1 - a2);
    else x = (c1 - c2) / (a2 - a1);
    return x;
}
double FuncY(double x, double c1, double a1)
{
    double y1 = a1 * x + c1;
    return y1;
}
