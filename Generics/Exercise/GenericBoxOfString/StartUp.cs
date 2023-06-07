namespace GenericBoxOfString
{
	using System;
	public class StartUp
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Box<double> box = new Box<double>();
			
			for (int i = 0; i < n; i++)
			{
			   double element = double.Parse(Console.ReadLine());

			   box.Add(element);
               //Console.WriteLine(box);

			}

			double value = double.Parse(Console.ReadLine());

            Console.WriteLine(box.Count(value));
        }
	}
}