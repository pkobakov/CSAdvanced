int[] array = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToArray();

for (int i = 0; i < 3; i++)
{
    Console.Write(array[i] + " ");
}  