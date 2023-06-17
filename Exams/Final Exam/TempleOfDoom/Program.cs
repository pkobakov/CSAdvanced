using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TempleOfDoom
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue<int> tools = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> substances = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            List<int> challenges = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());

            bool IsMatch = false;

            while (tools.Any() && substances.Any())
            {
                int sum = tools.Peek() * substances.Peek();

                //foreach (int item in challenges) 
                //{
                //    if (item == sum) 
                //	{
                //	   IsMatch = true;
                //	}
                //}

                //if (IsMatch)
                //{
                //	tools.Dequeue();
                //	substances.Pop();

                //	var challenge = challenges.FirstOrDefault(x => x == sum);
                //	challenges.Remove(challenge);
                //}

                var sortedChallenge = challenges.FirstOrDefault(c => c == sum);

                if (sortedChallenge != 0)
                {
                    tools.Dequeue();
                    substances.Pop();
                    challenges.Remove(sortedChallenge);
                }

                else
                {
                    int tool = tools.Dequeue();
                    tool += 1;
                    tools.Reverse();
                    tools.Enqueue(tool);

                    int substance = substances.Pop();
                    substance -= 1;
                    if (substance > 0)
                    {
                        substances.Push(substance);

                    }
                }
            }


            StringBuilder stringBuilder = new StringBuilder();

            if (challenges.Count > 0)
            {
                stringBuilder.AppendLine("Harry is lost in the temple. Oblivion awaits him.");
            }

            else
            {
                stringBuilder.AppendLine("Harry found an ostracon, which is dated to the 6th century BCE.");

            }



            if (tools.Count > 0)
            {
                stringBuilder.AppendLine($"Tools: {string.Join(", ", tools)}");
            }

            if (substances.Count > 0)
            {
                stringBuilder.AppendLine($"Substances: {string.Join(", ", substances)}");
            }

            if (challenges.Count > 0)
            {
                stringBuilder.AppendLine($"Challenges: {string.Join(", ", challenges)}");
            }

            Console.WriteLine(stringBuilder.ToString().TrimEnd());

        }
    }
}