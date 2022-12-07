Console.Clear();
Console.WriteLine("Введите числа");
int n = Convert.ToInt32(Console.ReadLine());

int max = n;
int max2 = n;

while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    
    if (n > max) 
    {
        max2 = max;
        max = n;
    }
    else if (n > max2 && n < max)
    {
        max2 = n;
    }
}

Console.WriteLine($"Второе максимальное число {max2}");