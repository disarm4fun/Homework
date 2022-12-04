Console.WriteLine("Введите цифру обозначающий день недели");
int number = int.Parse(Console.ReadLine()!);
if (number > 0 && number < 8)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Да,выходной");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("число не определяет день недели ");
}