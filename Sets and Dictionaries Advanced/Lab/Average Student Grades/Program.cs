int n = int.Parse(Console.ReadLine());
Dictionary<string,List<decimal>> grades = new Dictionary<string,List<decimal>>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();

    string name = input[0];
    decimal grade = decimal.Parse(input[1]);

    if (!grades.ContainsKey(name))
    {
        grades[name] = new List<decimal> { grade };

    }
    else 
    {
    
        grades[name].Add(grade);
    }

}

foreach (var item in grades)
{

    Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value.Select(x => $"{x:f2}"))} (avg: {item.Value.Average(x =>x):f2})");
}
