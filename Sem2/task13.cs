Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

if (number < 0 ) number = -number;

if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
while (number > 999)
{
    number = number / 10;
}
int result = number % 10;

Console.WriteLine(result);
}