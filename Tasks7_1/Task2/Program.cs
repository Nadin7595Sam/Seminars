void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите позиции элемента массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[4, 4];
InputMatrix(matrix);
Console.WriteLine();

size[0] = size[0] - 1;
size[1] = size[1] - 1;

if (size[0] >= matrix.GetLength(0) || size[1] >= matrix.GetLength(1))
    Console.WriteLine("Такого элемента нет");
else
    Console.WriteLine($"{matrix[size[0], size[1]]}");