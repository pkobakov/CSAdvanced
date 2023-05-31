namespace DateModifier
{
	using System;
	public class StartUp
	{
		public static void Main(string[] args)
		{

			DateModifier modifier = new DateModifier();
			List<string> dates = new List<string> { };
			
			for (int i = 0; i < 2; i++)
			{
		     	string command = Console.ReadLine();
				dates.Add(command);
			}

			Console.WriteLine(modifier.CalculateDifference(dates[0], dates[1]));
        }
	}
}