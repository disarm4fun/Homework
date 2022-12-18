Console.WriteLine("Сколько чисел вы хотите ввести");
int num = int.Parse(Console.ReadLine()!);

int[] arr = new int[num];
Console.WriteLine($"--> {АmountNumber(UserFillArray(arr))}");

int[] UserFillArray(int[] array)
{
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите {i + 1} число");
        arr[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

int АmountNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}