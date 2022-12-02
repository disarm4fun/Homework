Console.WriteLine("Введите третье число");
string num3 = Console.ReadLine()!;
int num3int = int.Parse(num3);

if (num1int > num2int)
{
    if (num1int > num3int)
    {
        Console.WriteLine(num1int + " Самое большое число ");
    }
    else
    {
        Console.WriteLine(num3int + " Самое большое число ");
    }
}
else
{
    if (num2int > num3int)
    {
        Console.WriteLine(num2int + " Самое большое число ");
    }
    else
    {
        Console.WriteLine(num3int + " Самое большое число ");
    }
}