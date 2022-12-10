Console.WriteLine("Введиче число");
int num1 = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= num1; i++)
{
    Console.WriteLine(i * i * i);
}