var n = int.Parse(Console.ReadLine());

var petrolStations = new Queue<int[]>();
int counter = 0;

for (int i = 0; i < n; i++)
{
    petrolStations.Enqueue(Console.ReadLine().Split().Select(int.Parse).ToArray());

}

while (true) 
{
    int fuelAmount = 0;
    var pumpFound = true;

    foreach (var station in petrolStations)
    {
        fuelAmount += station[0];

        if (fuelAmount < station[1]) 
        {
            pumpFound = false; break;   
        }

        fuelAmount -= station[1];
    }

    if (pumpFound) 
    {
        break;
    }

    counter++;
    petrolStations.Enqueue(petrolStations.Dequeue());
}

Console.WriteLine(counter);
