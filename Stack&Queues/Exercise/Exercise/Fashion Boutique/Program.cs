var clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
var rackCapacity = int.Parse(Console.ReadLine());

var delivery = new Stack<int>(clothes);
int rackCounter = 1;
int sum = 0;

while (delivery.Any()) 
{
    if (rackCapacity < sum + delivery.Peek())
    {
        rackCounter++;
        sum = 0;
    }
    sum += delivery.Pop();

}

Console.WriteLine(rackCounter);




