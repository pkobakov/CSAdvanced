string range = Console.ReadLine();


int[] rangeArgs = range.Split().Select(int.Parse).ToArray();
int start = rangeArgs[0];
int end = rangeArgs[1];

Predicate<int> checker = x => x % 2 == 0;

var numbers = CreateNumbers(start, end);

string command = Console.ReadLine();

List<int> result = command switch
{
"even" => numbers.Where(x => checker(x)).ToList(),
"odd" => numbers.Where(x => !checker(x)).ToList(),
_ => throw new ArgumentException("Invalid command!")
} ;

Console.WriteLine(string.Join(" ", result));

List<int> CreateNumbers(int start, int end)
{
    List<int> numbers = new List<int>();
    for (int i = start; i <= end; i++)
    {
        numbers.Add(i);
    }

    return numbers;
}