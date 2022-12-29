Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество строк");
int lines = int.Parse(Console.ReadLine()!);

int[,] matrix = Fill2DArray(columns, lines, 1, 10);
Print2DMatrix(matrix);
int[,] sorted = SortDescendArray(matrix);
Console.WriteLine();
Print2DMatrix(matrix);

int[,] Fill2DArray(int size1, int size2, int min, int max)
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
int[,] SortDescendArray(int[,] noSort)
{
    int size1 = noSort.GetLength(0);
    int size2 = noSort.GetLength(1);

    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2 - 1; j++)
        {
            for (int k = j; k < size2; k++)
            {
                if (noSort[i, j] < noSort[i, k])
                {
                    int temporary = noSort[i, k];
                    noSort[i, k] = noSort[i, j];
                    noSort[i, j] = temporary;
                }
            }
        }
    }
    return noSort;
}
void Print2DMatrix(int[,] array)
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