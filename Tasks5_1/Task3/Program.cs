// Задача 38. Задайте массив вещественных чисел.
//            Найдите разницу между максимальным и минимальным элементов массива.

void InputArray(int[] array)
	{
	    for (int i = 0; i < array.Length; i++)
	        array[i] = new Random().Next(1, 100); // [1, 99]
	}

void ReleaseArray(int[] array)
{
    int maxValue = array[0];
    int minValue = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxValue)
            maxValue = array[i];
        if(array[i] < minValue)
            minValue = array[i];
    }

    Console.WriteLine("Максимальный элемент: " + maxValue);
    Console.WriteLine("Минимальный элемент: " + minValue);
    Console.WriteLine($"Разность: {(maxValue - minValue)}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);