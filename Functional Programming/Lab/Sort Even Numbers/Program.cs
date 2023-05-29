string input = Console.ReadLine();

int[] result = input.Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .Where(x => x%2==0)
                    .OrderBy(x => x)
                    .ToArray();

Console.WriteLine( string.Join(", ", result));
