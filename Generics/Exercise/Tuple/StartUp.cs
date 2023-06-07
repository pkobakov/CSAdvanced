namespace Tuple
{
	using System;
    using System.Text;

    public class StartUp
	{
		public static void Main(string[] args)
		{
			
			StringBuilder sb = new StringBuilder();	

			string [] firstLine = Console.ReadLine().Split().ToArray();
			string fullName = $"{firstLine[0]} {firstLine[1]}";
			string address = firstLine[2];
			
			CustomTuple<string, string> nameAndAddress = new CustomTuple<string, string> ( fullName, address);
			sb.AppendLine(nameAndAddress.ToString());

            string[] secondLine = Console.ReadLine().Split().ToArray();
            string name = secondLine[0];
            int beers = int.Parse(secondLine[1]);
			CustomTuple<string, int> nameAndBeers = new CustomTuple<string, int>(name, beers);
			sb.AppendLine(nameAndBeers.ToString());

            string[] thirdLine = Console.ReadLine().Split().ToArray();
            int intgr = int.Parse(thirdLine[0]);
            double doubl = double.Parse(thirdLine[1]);
			CustomTuple<int, double> integerAndDouble = new CustomTuple<int, double>(intgr, doubl);
			sb.AppendLine(integerAndDouble.ToString());



            Console.WriteLine(sb.ToString().TrimEnd());

        }
	}
}