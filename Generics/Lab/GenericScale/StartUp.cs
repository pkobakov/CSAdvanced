namespace GenericScale
{
	using System;
	public class StartUp
	{
		public static void Main(string[] args)
		{
			int a = 1;
			int b = 2;


			EqualityScale<int> equality = new EqualityScale<int>(a, b);

			Console.WriteLine(equality.AreEqual());

		}
	}
}
