namespace GenericBoxOfString
{
	using System;
	public class StartUp
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Box<string> box = new Box<string>();
			
			for (int i = 0; i < n; i++)
			{
			   string element = Console.ReadLine();

			   box.Add(element);
               //Console.WriteLine(box);

			}

			string value = Console.ReadLine();

            Console.WriteLine(box.Count(value));
        }
	}
}