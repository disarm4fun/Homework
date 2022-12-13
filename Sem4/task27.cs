Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

int SumFromFunc = CalculateSum(number);
Console.WriteLine(SumFromFunc);

int CalculateSum(int num)
{
    int result = 0;
    for (int i = 0; i <= result; i++)
    {
        result += num % 10;
        num /= 10;
    }
    return result + num;
}