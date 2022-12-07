Console.Clear();
Console.WriteLine ("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
 
while (n > 1000)
{
    n /= 10;
}

if (n > 100)
{ 
    int x = ((n % 100)% 10);
    Console.WriteLine(x);
}
else
{
    Console.WriteLine ("Третьей цифры нет");
}