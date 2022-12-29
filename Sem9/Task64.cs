Console.Write("Введите число N ");
int N = int.Parse(Console.ReadLine()!);

Console.Write(AllToN(N));

string AllToN(int n)
{
    if (n == 1)
    {
        return n.ToString();
    }
    else
    {
        return n.ToString() + ", " + AllToN(n - 1);
    }
}