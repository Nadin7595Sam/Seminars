// Задача 29: Напишите программу, которая спрашивает у пользователя кол-во элементов и спршивает сами элементы. После записи элементов в массив, необходимо его вывести на экран.

Console.Clear();
Console.Write("Введите количество элементов: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];

for(int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент {i}: ");    
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine();

for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}