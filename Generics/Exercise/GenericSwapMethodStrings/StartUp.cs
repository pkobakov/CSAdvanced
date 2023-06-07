namespace GenericSwapMethodStrings
{
    using System;
    using System.Runtime.CompilerServices;

    public class StartUp
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

	        SwapStrings<string> swapStrings = new SwapStrings<string>();

			for (int i = 0; i < n; i++)
			{
				swapStrings.Add(Console.ReadLine());
			}

			int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

			swapStrings.Swap(indexes[0], indexes[1]);

			Console.WriteLine(swapStrings.ToString());
		}
	}
}