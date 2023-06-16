using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace ConsoleApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Queue<int> timesNeededToEarn = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
			Stack<int> tasks = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray()); 

			Dictionary<string , int > tasksCounter = new Dictionary<string, int>()
			{
                { "Darth Vader Ducky", 0},
                { "Thor Ducky", 0},
				{ "Big Blue Rubber Ducky", 0},
				{ "Small Yellow Rubber Ducky", 0} 
			};


			while (timesNeededToEarn.Count>0 && tasks.Count>0)
			{
				int multiply = timesNeededToEarn.Peek() * tasks.Peek();

				if (multiply > 0 && multiply < 60)
				{
					timesNeededToEarn.Dequeue();
					tasks.Pop();
					tasksCounter["Darth Vader Ducky"]++;
				}

				else if (multiply > 61 && multiply < 120) 
				{
                    timesNeededToEarn.Dequeue();
                    tasks.Pop();
                    tasksCounter["Thor Ducky"]++;
                }

                else if (multiply > 121 && multiply < 180)
                {
                    timesNeededToEarn.Dequeue();
                    tasks.Pop();
                    tasksCounter["Big Blue Rubber Ducky"]++;
                }

                else if (multiply > 181 && multiply < 240)
                {
                    timesNeededToEarn.Dequeue();
                    tasks.Pop();
                    tasksCounter["Small Yellow Rubber Ducky"]++;
                }

				else if(multiply > 240)
				{
					int currentTaskValue = tasks.Pop();
					currentTaskValue -= 2;
					tasks.Push(currentTaskValue);
				}


            }

			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");

			foreach (var task in tasksCounter) 
			{
				stringBuilder.AppendLine($"{task.Key}: {task.Value}"); 
			}

            Console.WriteLine(	stringBuilder.ToString().TrimEnd());
        }
	}
}