Console.WriteLine("Введите первое число");
string num1 = Console.ReadLine()!;
int num1int = int.Parse(num1);

if (num1int % 2 == 0)
{
    Console.WriteLine(num1int + " число чётное ");
}
else
{
    Console.WriteLine(num1int + " число не чётное ");
}