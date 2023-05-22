int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = sizes[0];
int m = sizes[1];

HashSet<int> s = new HashSet<int>();
HashSet<int> t = new HashSet<int>();
HashSet<int> result = new HashSet<int>();

for (int i = 0; i < n; i++)
{
    s.Add(int.Parse(Console.ReadLine()));
}

for (int i = 0; i < m; i++)
{
    t.Add(int.Parse(Console.ReadLine()));


}


result = s.Intersect(t).ToHashSet();


Console.WriteLine( string.Join(" ", result) );