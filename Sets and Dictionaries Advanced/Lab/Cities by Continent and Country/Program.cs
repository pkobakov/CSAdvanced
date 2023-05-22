int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, List<string>>> geography = new Dictionary<string, Dictionary<string, List<string>>>();


for (int i = 0; i < n; i++)
{
	string[] input = Console.ReadLine().Split().ToArray();
	string continent = input[0];
	string country = input[1];
	string city = input[2];


	if (!geography.ContainsKey(continent))
	{
		geography.Add(continent, new Dictionary<string, List<string>> ());
	}

	if (!geography[continent].ContainsKey(country))
	{
		geography[continent].Add(country, new List<string> ());
	}

	
	   geography[continent][country].Add(city);
	

}


foreach (var currentContinent in geography)
{
    Console.WriteLine($"{currentContinent.Key}:");

	foreach (var currentCountry in currentContinent.Value)
	{
        Console.WriteLine($" {currentCountry.Key} -> {string.Join(", ", currentCountry.Value)}");
    }

}


