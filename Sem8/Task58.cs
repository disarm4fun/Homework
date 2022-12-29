Console.WriteLine("Введите число строк 1-й матрицы: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов 2-й матрицы: ");
int p = int.Parse(Console.ReadLine()!);

int[,] firstMatrix = new int[m, n];
CreateArray(firstMatrix);
Console.WriteLine($"Первая матрица:");
Print2DArray(firstMatrix);

int[,] secondMatrix = new int[n, p];
CreateArray(secondMatrix);
Console.WriteLine($"Вторая матрица:");
Print2DArray(secondMatrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
Print2DArray(resultMatrix);

void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0,10);
    }
  }
}

void Print2DArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + "|");
    }
    Console.WriteLine();
  }
}