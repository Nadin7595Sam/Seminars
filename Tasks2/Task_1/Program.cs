Console.Clear();

Console.WriteLine("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int n1 = n / 100;
int n2 = n / 10 % 10;
int n3 = n % 10;

if (n > 100 && n < 1000)
    Console.WriteLine(n2);
else
    Console.WriteLine("Число не трёхзначное!");