string command = Console.ReadLine();
HashSet<string> regularGuests = new HashSet<string>();
HashSet<string> VIPguests = new HashSet<string>();
HashSet<string> partyGuests = new HashSet<string>();
int counter = 0;    

while (command != "PARTY") 
{
	
	char[] guestCode = command.ToCharArray();
	char firstSymbol = guestCode[0];

	if (char.IsDigit(firstSymbol)) 
	{
		VIPguests.Add(command);
	}

	else
	{
		regularGuests.Add(command);
	}

    command = Console.ReadLine();   
}

while (command != "END")
{
    char[] guestCode = command.ToCharArray();
    char firstSymbol = guestCode[0];

    if (char.IsDigit(firstSymbol))
    {
        partyGuests.Add(command);
        VIPguests.Remove(command);
        
    }

    else
    {
        partyGuests.Add(command);
        regularGuests.Remove(command);
    }
    command = Console.ReadLine();
}

Console.WriteLine(  $"{VIPguests.Count + regularGuests.Count}");
foreach (string name in VIPguests) 
{
    Console.WriteLine(name); 
}
foreach (string name in regularGuests)
{
    Console.WriteLine(name);
}

