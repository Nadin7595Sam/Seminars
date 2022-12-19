// Задача 34. Задайте массив, заполненный случайными положительными трёхзначными числами.
//            Напишите программу, которая покажет количество чётных чисел в массиве.

void InputArray(int[] array)
	{
	    for (int i = 0; i < array.Length; i++)
	        array[i] = new Random().Next(-10, 100); // [-10, 99]
	}

void ReleaseArray(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
            sum = sum + array[i];
    }
    Console.WriteLine($"Сумма элементов на нечётных позициях: " + sum);
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);