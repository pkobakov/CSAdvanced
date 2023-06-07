namespace GenericBoxOfString
{
	using System;
	public class StartUp
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
			   int s = int.Parse(Console.ReadLine());
			   Box<int> box = new Box<int>(s);
               Console.WriteLine(box);

			}
        }
	}
}