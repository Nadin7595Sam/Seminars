Console.Clear();
Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = Convert.ToInt32(new Random().Next(0, 10));
}
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t  ");
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < n; i++) 
{
    int a = 0;
    for (int t = 0; t < n; t++)
    {
        a = a + array[t, i];
    }
    Console.WriteLine($"Столбец {i + 1} = {Math.Round((double) a / m , 2)}");
}