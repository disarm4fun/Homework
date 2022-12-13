Console.WriteLine("Число А");
int numberA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Число B");
int numberB = int.Parse(Console.ReadLine()!);

int NaturalNumber = Power(numberA,numberB);
Console.WriteLine(NaturalNumber);

int Power(int numberA, int numberB)
{
    int result = numberA;
    for (int i = 1; i < numberB; i++)
    {
        result *= numberA;
    }
    return result;
}