var conditions = Console.ReadLine().Split().Select(int.Parse).ToArray();
var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

var n = conditions[0];
var s = conditions[1];  
var x = conditions[2];


var queue = new Queue<int>();
int min = int.MaxValue;
string result = null;

for (int i = 0; i < n; i++)
{
    queue.Enqueue(numbers[i]);
}

for (int i = 0; i < s; i++)
{

    if (queue.Any())
    {
        queue.Dequeue();

    }

    else 
    {
        break; 
    }
}

if (queue.Contains(x))
{
    result = "true";
}

else 
{

    if (queue.Any())
    {
        result = $"{queue.Min()}";
    }

    else 
    {
        result = "0";
           
    }

}



Console.WriteLine(result);