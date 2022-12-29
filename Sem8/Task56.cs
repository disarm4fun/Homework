Random rnd = new Random();

int size1 = rnd.Next(5, 7);
int size2 = rnd.Next(4, 5);
int min = rnd.Next(1, 10);
int max = rnd.Next(10, 50);

int[,] matrix = CreateMatrix(size1, size2, min, max);
PrintMatrix(matrix);
Console.WriteLine();
int line = FindMinimalLine(matrix);
if (line >= 0)
{
    Console.WriteLine("Минимальная сумма в строке :" + line);
}
else
{
    Console.WriteLine("Минимальная сумма дублируется");
}

int FindMinimalLine(int[,] inner)
{
    int findIt = -1;
    int minValue = int.MaxValue;
    for (int i = 0; i < inner.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < inner.GetLength(1); j++)
        {
            rowSum += inner[i, j];
        }
        if (minValue > rowSum)
        {
            findIt = i;
            minValue = rowSum;
        }
        else if (minValue == rowSum)
        {
            return minValue;
        }
        
    }
    return findIt;
}


int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum =0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}");
            sum += matrix[i,j];
        }
        Console.WriteLine("   ->  "+sum);
    }
}