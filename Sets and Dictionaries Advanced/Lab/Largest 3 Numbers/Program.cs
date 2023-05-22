int[] array = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToArray();

if (array.Length < 3) 
{

   for (int i = 0; i < array.Length; i++)
   {
       Console.Write(array[i] + " ");
   }  

}

else
{
    for (int i = 0; i < 3; i++)
    {
        Console.Write(array[i] + " ");
    }
}