double[] inputNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();


Dictionary<double, int> dictionary = new Dictionary<double, int>();

foreach (var number in inputNumbers) 
{
    if (!dictionary.ContainsKey(number)) 
    {
        dictionary.Add(number, 0);
    }

    dictionary[number]++; 
}

foreach (var item in dictionary.Keys) 
{
    Console.WriteLine($"{item} - {dictionary[item]} times");

} 
