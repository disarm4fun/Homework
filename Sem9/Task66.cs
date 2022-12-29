Console.Write("Введите число M ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N ");
int N = int.Parse(Console.ReadLine()!);

Console.Write(SumFromMToN(M, N));


int SumFromMToN(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return m + SumFromMToN(m + 1, n);
    }
}