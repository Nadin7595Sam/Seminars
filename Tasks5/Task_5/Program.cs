// dop
	Console.Clear();
	int n = Convert.ToInt32(Console.ReadLine());
	int[] array = new int[n];
	for (int i = 0; i < array.Length; i++)
	    array[i] = new Random().Next(1, 11); // [1, 10]
	
	Console.WriteLine($"[{string.Join(", ", array)}]");
	int maxSum = 0;
	for (int i = 1; i < array.Length - 1; i++)
	{
	    if (array[i - 1] + array[i] + array[i + 1] > maxSum)
	        maxSum = array[i - 1] + array[i] + array[i + 1];
	}
	
	if (array[0] + array[1] + array[array.Length - 1] > maxSum)
	    maxSum = array[0] + array[1] + array[array.Length - 1];
	if (array[0] + array[array.Length - 2] + array[array.Length - 1] > maxSum)
	    maxSum = array[0] + array[array.Length - 2] + array[array.Length - 1];
	
	Console.WriteLine(maxSum);