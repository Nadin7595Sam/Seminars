// Задача 34. Задайте массив, заполненный случайными положительными трёхзначными числами.
//            Напишите программу, которая покажет количество чётных чисел в массиве.

void InputArray(int[] array)
	{
	    for (int i = 0; i < array.Length; i++)
	        array[i] = new Random().Next(100, 1000); // [100, 999]
	}

void ReleaseArray(int[] array)
{
    int evenNumberCount = 0; // чётные числа
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            evenNumberCount++;
    }
    Console.WriteLine($"Количество чётных чисел: " + evenNumberCount);
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);