Console.Write("Ввеите количество столбцов ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Ввеите количество строк ");
int lines = int.Parse(Console.ReadLine()!);
Console.Write("Ввеите минимальное значение ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Ввеите максимальное значение ");
int max = int.Parse(Console.ReadLine()!);

int[,] matrix = FillArray(lines, columns, min, max);
PrintMatrix(matrix);

Console.Write("Введите горизонтальное положение ");
columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите вертикальное положение ");
lines = int.Parse(Console.ReadLine()!);
FindAtPosition(matrix, columns, lines);


int[,] FillArray(int size1, int size2, int min, int max)
{
    int[,] matrix = new int[size1, size2];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FindAtPosition(int[,] inFound, int posX, int posY)
{
    if (posX <= inFound.GetLength(0) && posY <= inFound.GetLength(1) && posX >= 0 && posY >= 0)
    {
        Console.WriteLine($"В {posX},{posY} найден :{inFound[posY, posX]}");
    }
    else
    {
        Console.WriteLine("эта позиция вне диапазона массива");
    }
}