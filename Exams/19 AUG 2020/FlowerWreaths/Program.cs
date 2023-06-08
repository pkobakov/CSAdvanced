using System;
using System.Linq;
using System.Collections.Generic;

namespace FlowerWreaths
{


	public class Program
	{
		public static void Main(string[] args)
		{
			Stack<int> stackOfLilies = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
			Queue <int> queueOfRoses = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

			int wreathscount = 0;
			int sumOfFlowers = 0;


			while (queueOfRoses.Any() && stackOfLilies.Any()) 
			{
				if (stackOfLilies.Peek() + queueOfRoses.Peek() == 15)
				{
					stackOfLilies.Pop();
					queueOfRoses.Dequeue();

					wreathscount++; continue;
				}

				if (stackOfLilies.Peek() + queueOfRoses.Peek() > 15)
				{
					int currentElement = stackOfLilies.Pop();
					currentElement -= 2;
					stackOfLilies.Push(currentElement);continue;
				}

				if (stackOfLilies.Peek() + queueOfRoses.Peek() < 15)
				{
					sumOfFlowers += stackOfLilies.Pop() + queueOfRoses.Dequeue();continue;
					
				}
			}

			int moreWreaths = sumOfFlowers / 15;
			wreathscount += moreWreaths;

			string summary = wreathscount >= 5 ? $"You made it, you are going to the competition with {wreathscount} wreaths!" 
				                               : $"You didn't make it, you need {5 - wreathscount} wreaths more!";
            Console.WriteLine(summary);

        }
	}
}