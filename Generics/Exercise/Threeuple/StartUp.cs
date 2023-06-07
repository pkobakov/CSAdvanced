namespace Threeuple
{
	using System;
    using System.Text;

    public class StartUp
    {
		public static void Main(string[] args)
		{
            StringBuilder sb = new StringBuilder();

            string[] firstLine = Console.ReadLine().Split().ToArray();
            string fullName;
            string address;
            string town;
            if (firstLine.Length == 4)
            {
               fullName = $"{firstLine[0]} {firstLine[1]}";
               address = firstLine[2];
               town = firstLine[3];
            }
            else 
            {
                fullName = $"{firstLine[0]} {firstLine[1]}";
                address = firstLine[2];
                town = $"{firstLine[3]} {firstLine[4]}";
            }

            CustomThreeuple<string, string, string> nameAddressTown = new CustomThreeuple<string, string, string>(fullName, address, town);
            sb.AppendLine(nameAddressTown.ToString());

            string[] secondLine = Console.ReadLine().Split().ToArray();
            string name = secondLine[0];
            int beers = int.Parse(secondLine[1]);
            bool isDrunk = secondLine[2] == "drunk" ? true : false;
            CustomThreeuple<string, int, bool> nameBeersState = new CustomThreeuple<string, int, bool>(name, beers, isDrunk);
            sb.AppendLine(nameBeersState.ToString());

            string[] thirdLine = Console.ReadLine().Split().ToArray();
            string account = thirdLine[0];
            double balance = double.Parse(thirdLine[1]);
            string bank = thirdLine[2];
            CustomThreeuple<string, double, string> bankAccount = new CustomThreeuple<string, double, string>(account, balance, bank);
            sb.AppendLine(bankAccount.ToString());

            Console.WriteLine(  sb.ToString());
        }
	}
}