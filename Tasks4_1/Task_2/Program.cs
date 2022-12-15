// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
nint sum = 0;
while(n > 0)
{
    count++;
    sum += n % 10;
    n /= 10;
}
Console.WriteLine(sum);