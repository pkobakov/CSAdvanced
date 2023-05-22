int n = int.Parse(Console.ReadLine());
List<string> collection = new List <string> ();
HashSet<string> list = new HashSet<string>();

for (int i = 0; i < n; i++)
{
    string[] inputTokens = Console.ReadLine().Split().ToArray();
	for (int j = 0; j < inputTokens.Length; j++)
	{
		collection.Add(inputTokens[j]);
	}
}

foreach (string s in collection.OrderBy(x => x)) 
{
     list.Add(s);
}
Console.WriteLine(string.Join(" ", list));
