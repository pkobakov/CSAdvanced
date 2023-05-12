var numbers = Console.ReadLine().Split().Select(int.Parse);
int n = numbers.Count();
Queue<int> queue = new Queue<int>(numbers);
var list = new List<int>();


foreach (var number in numbers) 
{
    if (number % 2 == 0) 
    {
        list.Add(queue.Dequeue());
    }

    else 
    {
        queue.Dequeue();
    
    }

}

Console.WriteLine(string.Join(", ", list));


