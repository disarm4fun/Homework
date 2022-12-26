int[,] matrix = CreateMatrix(4, 4, -5, 10);
PrintMatrix(matrix);
PrintArray(Average(matrix));

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
 
 
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

int[,] CreateMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min,max);
        }
    }
    return matrix;
}
double[] Average(int[,] matrix)
{
    int columnCount = matrix.GetLength(1);
    int rowCount = matrix.GetLength(0);
    double[] result = new double[columnCount];

    for (int j = 0; j < columnCount; j++)
    {
        int sum = 0;
        for (int i = 0; i < rowCount; i++)
        {
            sum += matrix[i,j];
        }
        result[j] = Math.Round((double)sum / rowCount, 2);
    }
    return result;
}