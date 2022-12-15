Console.Clear();

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
for(int i = 0; i < array.Length; i++)
{
    //                                              * (end - begin) + begin            
    array[i] = Math.Round(new Random().NextDouble() * (50 - 10) + 10, 2); //[0, 1]
}

Console.WriteLine($"[{string.Join(", ", array)}]");