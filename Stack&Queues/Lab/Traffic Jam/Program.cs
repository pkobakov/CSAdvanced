var n = int.Parse(Console.ReadLine());
var command = Console.ReadLine();
int count = 0;  

var cars = new Queue<string>();
while (command.ToLower() != "end") 
{
    if (command.ToLower() == "green") 
    {
        if (cars.Count < n ) 
        {
            while (cars.Count > 0) 
            {

                count++;
                Console.WriteLine($"{cars.Dequeue()} passed!");
            }
        }
        else
        {
            for(int i = 0; i < n; i ++) 
            {
               count ++;   
               Console.WriteLine($"{cars.Dequeue()} passed!");
            }

        }

    }

    else
    {
        cars.Enqueue(command);

    }

    command = Console.ReadLine();
}

Console.WriteLine($"{count} cars passed the crossroads.");



