Console.Clear();
Console.WriteLine("Введите кол-во столбцов: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во строк: ");
int b = Convert.ToInt32(Console.ReadLine());

while (a == b)
{
    Console.WriteLine("Вы ошиблись!");
    Console.WriteLine("Введите кол-во столбцов: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во строк: ");
    b = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();

int[,] matrix = new int[a, b];
CreateMatrix(matrix);
WriteMatrix(matrix);

int minSumLine = 0;
int sumLine = SumLineElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(matrix, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine();
Console.WriteLine($"{minSumLine + 1} строкa с наименьшей суммой элементов: {sumLine} ");


int SumLineElements(int[,] matrix, int i)
{
    int sumLine = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sumLine = sumLine + matrix[i, j];
    }
    return sumLine;
}


void CreateMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 10);
    }
  }
}

void WriteMatrix (int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
  }
}