// void

Console.Clear();

/*void test(int a)
{
    a+=5;
}

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
test(n);
Console.WriteLine(n);*/

void test(ref int a, ref int b)
{
    a+=5;
    b+=5;
}

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), b = 10;
test(ref n, ref b);
Console.WriteLine(n);
Console.WriteLine(b);