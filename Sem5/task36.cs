Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите нижнюю границу диапазона заполнения");
int min = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите верхнюю границу диапазона заполнения");
int max = int.Parse(Console.ReadLine()!);
Random rnd = new Random();

int[] array = new int[num];

int[] a2 = FillArray(array, num , min, max);
int counts = ArraySum(a2);
Console.Write(" --> " + counts);

ArraySum(array);

int[] FillArray(int[] arr, int num , int fmin, int fmax)
{
    for (int i = 0; i < arr.Length; i++) 
    {
        arr[i] = rnd.Next(fmin, fmax + 1);
        Console.Write(arr[i] + " ");
    }
    return arr;
}

int ArraySum(int[] array)
{
    int SumArray = 0;

    for (int i = 1; i < array.Length; i += 2)
    {
        SumArray += array[i];
    }
    return SumArray; 
}