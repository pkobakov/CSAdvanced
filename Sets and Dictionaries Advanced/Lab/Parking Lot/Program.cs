HashSet<string> parkingLot = new HashSet<string>();

string input = Console.ReadLine();

while (input != "END")
{
    string[] cmdArgs = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    string action = cmdArgs[0];
    string carNumber = cmdArgs[1];

    switch (action) 
    {
        case "IN": parkingLot.Add(carNumber); break;
        case "OUT": parkingLot.Remove(carNumber); break;
            default:throw new ArgumentException("Invalid Car Number"); break;
    }

    

    input = Console.ReadLine();
}

if (parkingLot.Count > 0) 
{

     foreach (string arg in parkingLot) { Console.WriteLine(arg); }

}

else
{
    Console.WriteLine("Parking Lot is Empty");
}