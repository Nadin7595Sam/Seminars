Console.Clear();
Console.Write("Введите количество строк 1 массива: ");
int rowsA = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 1 массива: ");
int columnsA = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк 2 массива: ");
int rowsB = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 2 массива: ");
int columnsB = int.Parse(Console.ReadLine());

if (columnsA != rowsB)
{
    Console.WriteLine("Вы ошиблись!");
    return;
}

int[,] A = GetMatrix(rowsA, columnsA, 0, 10);
int[,] B = GetMatrix(rowsB, columnsB, 0, 10);
PrintMatrix(A);
Console.WriteLine();
PrintMatrix(B);
Console.WriteLine();
PrintMatrix(GetMultiplicationMatrix(A,B));

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Console.Write($"{inMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int [,] GetMultiplicationMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;
            matrixC[i, j] += matrixA[i, j] * matrixB[i, j];
        }
    }
    return matrixC;
}