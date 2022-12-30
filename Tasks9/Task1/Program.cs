int rec(int m, int n, int sum)
{
    if (m <= n)
    {
        Console.Write(m + " ");
        sum = sum + m;
        m++;
        return rec(m, n, sum);
    }
    Console.WriteLine();
    return sum;
}

Console.Clear();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Console.Write(rec(m, n, sum));