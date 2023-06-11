using System;
using System.Collections.Generic;
namespace Scheduling
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Stack<int> tasks  = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
			Queue<int> threads = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

			int killTask = int.Parse(Console.ReadLine());

			while ( threads.Count > 0 ) 
			{			
			    if (tasks.Peek() <= threads.Peek() && tasks.Peek() != killTask) 
			    {
			        tasks.Pop();
				    threads.Dequeue(); continue;
			    }

      			if (threads.Peek() < tasks.Peek() && tasks.Peek() != killTask) 
		     	{
			       threads.Dequeue();continue;
			    }

		     	if (tasks.Peek() == killTask)
			    {

                    Console.WriteLine($"Thread with value {threads.Peek()} killed task {killTask}"); break;
                }

            }
            
			Console.WriteLine(string.Join(" ", threads));
		}
	}
}

            