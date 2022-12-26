double[,] matrix = CreateMatrix(4, 4, -5, 10);
PrintMatrix(matrix);

void PrintMatrix(double[,] array)
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

double[,] CreateMatrix(int m, int n, int min, int max)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((max - min) * new Random().NextDouble() + min, 1);
        }
    }
    return matrix;
}