var playlist = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
var songsQueue = new Queue<string>(playlist);

while (songsQueue.Any()) 
{
    var commandArgs = Console.ReadLine().Split().ToArray();
    var command = commandArgs[0];

    

    switch (command) 
    {
        case "Play":

            songsQueue.Dequeue(); 

            if (!songsQueue.Any())
            {
                Console.WriteLine("No more songs!"); return; 
            }

            break;

        case "Add":
            var list =new List<string>(commandArgs);
            var newSong = string.Join(" ", list.Skip(1));

            if (songsQueue.Contains(newSong)) 
            {
                Console.WriteLine( $"{newSong} is already contained!");

            }
            else 
            {
                 songsQueue.Enqueue(newSong);   
            }; 
            
            break;
        case"Show": 

            Console.WriteLine(string.Join( ", ", songsQueue));  break;
            default:; break;    
    }

}
