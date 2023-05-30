List<Predicate<int>> predicates = new List<Predicate<int>>();
int range = int.Parse(Console.ReadLine());
HashSet<int> deviders = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToHashSet(); 

int[] numbers = Enumerable.Range(1, range).ToArray();

foreach (int devider in deviders) 
{
    predicates.Add(x => x%devider == 0);
}

foreach (int number in numbers) 
{
    bool isDivisible = true;

    foreach (var currentPredicate in predicates)
    {
        if (!currentPredicate(number))
        {
            isDivisible = false;break;
        }
    }

    if (isDivisible) 
    {
        Console.Write($"{number} ");
    }
}