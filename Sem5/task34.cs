Console.WriteLine("Введите нижнюю границу диапазона заполнения");
int min =int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите верхнюю границу диапазона заполнения");
int max =int.Parse(Console.ReadLine()!);
Random rnd = new Random();

int[] array = new int[rnd.Next(5,25)];

int[] a2 = FillArray(array, min, max);
int counts = EvenCount(a2);
Console.Write(" --> " + counts);

ArrayMultiPairs(array);
int[] FillArray(int[] field, int fmin, int fmax)
{
    for (int i = 0; i < field.Length; i++)
    {
        field[i] = rnd.Next(fmin, fmax + 1);
        Console.Write(field[i] + " ");
    }
    
    return field;
}

int EvenCount(int[] arr) 
{
    int cntr = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            cntr++;
        }
    }
    return cntr;
}

int[] ArrayMultiPairs(int[] array)
{
    int[] arrayNew = new int[(array.Length + 1)/ 2];

    for (int i = 0; i < array.Length / 2; i++)
    {
        arrayNew[i] = array[i] * array[array.Length-i-1];
    }
    if (array.Length % 2 != 0) arrayNew[arrayNew.Length-1] = array[array.Length / 2];

    return arrayNew; 
}