using System.Runtime.InteropServices;

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
int number = int.Parse( Console.ReadLine());

Func<List<int>, int, List<int>> action = (x, y) => Reverse(x,y) ;

Console.WriteLine( string.Join(" ", action(numbers, number)));


List<int> Reverse(List<int> list, int n) 
{
   Predicate<int> checker = x => x % n == 0;
   return list.Where(x => !checker(x) ).Reverse().ToList();
}

