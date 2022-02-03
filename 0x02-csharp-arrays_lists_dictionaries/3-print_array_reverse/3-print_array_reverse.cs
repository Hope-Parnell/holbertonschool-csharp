using System;

class Array
{
	public static void Reverse(int[] array)
	{
		if (array == null || array.Length < 1)
		{
			Console.WriteLine();
		}
		else
		{
			for (int i = array.Length - 1; i > 0; i--)
			Console.Write("{0} ", array[i]);
			Console.WriteLine(array[0]);
		}
	}
}
