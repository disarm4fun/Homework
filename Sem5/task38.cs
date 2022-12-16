Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите нижнюю границу диапазона заполнения");
int min = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите верхнюю границу диапазона заполнения");
int max = int.Parse(Console.ReadLine()!);
Random rnd = new Random();

double[] array = new double[num];

double[] a2 = FillArray(num, min, max);
double counts = Minmax(a2);
PrintArray(a2);
Console.Write(" --> " + counts);

double[] FillArray(int temp, int fmin, int fmax)
{
    double[] field = new double[temp];
    for (int i = 0; i < field.Length; i++)
    {
        field[i] = new Random().Next(fmin, fmax + 1);
    }
    return field;
}

double Minmax(double[] arr)
{
    double minFind = 100;
    double maxFind = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (minFind > arr[i])
        {
            minFind = arr[i];
        }
        if (maxFind < arr[i])
        {
            maxFind = arr[i];
        }
    }
    return maxFind - minFind;
}
void PrintArray(double[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}