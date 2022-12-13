Console.WriteLine("num");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("min");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("max");
int max = int.Parse(Console.ReadLine()!);

int[] array = new int[num];

FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
