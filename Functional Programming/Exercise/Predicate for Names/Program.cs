int n = int.Parse(Console.ReadLine());
List<string> names = Console.ReadLine().Split().ToList();

Predicate<string> checker = x => x.Length <= n;

foreach (var name in names.Where(n => checker(n)))
{
    Console.WriteLine( name);
}