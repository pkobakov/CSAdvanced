using System.Security.Cryptography.X509Certificates;

List<string> names = Console.ReadLine().Split().ToList();



string command = Console.ReadLine();
while (command != "Party!") 
{
    string[] commandArs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    string action = commandArs[0];
    string filter = commandArs[1];
    string value = commandArs[2];

    if (action == "Remove")
    {
        names.RemoveAll(GetPredicate(filter, value));
    }

    else
    {
       List<string> sortedNames = names.FindAll(GetPredicate(filter, value));

        foreach (string name in sortedNames) 
        {
           int index = names.IndexOf(name);
           names.Insert(index, name);
        
        }
    }

     command = Console.ReadLine();
}

if (!names.Any())
{
    Console.WriteLine("Nobody is going to the party!");

}

else
{
    if (names.Count == 1)
    {
        Console.WriteLine($"{string.Join(" ", names)}is going to the party!");
    }
    else 
    {
        Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
    
    }
}


static Predicate<string> GetPredicate(string filter, string value) 
{
    switch (filter) 
    {
        case "StartsWith": return n => n.StartsWith(value);break;
        case "EndsWith": return n => n.EndsWith(value); break;
        case "Length": return n => n.Length == int.Parse(value);break; 
        default: return default; break;
    }
}