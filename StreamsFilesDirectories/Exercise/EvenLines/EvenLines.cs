namespace EvenLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            StreamReader inputStreamReader = new StreamReader(inputFilePath);

            using (inputStreamReader)
            {
                string line = inputStreamReader.ReadLine();
                int count = 0;

                while (true) 
                {
                   if (line == null) break;

                   if (count % 2 == 0) 
                   {
                        string wordsReplacedSymbols = ReplacedSymbols(line);
                        string reversedWords = ReversedWords(wordsReplacedSymbols);
                        sb.AppendLine(reversedWords);
                   }

                   count++;
                   line = inputStreamReader.ReadLine();
                }
            }
                return sb.ToString().Trim() ;

        }

        private static string ReversedWords(string words)
        {
            string[] reverseWords = words.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                   .Reverse()
                                                   .ToArray();

            return string.Join(" ", reverseWords) ;
        }

        private static string ReplacedSymbols(string line)
        {
            var sb = new StringBuilder(line);
            char[] symbols = { '-',',','.','?','!'};

            foreach (char symbol in symbols) 
            {
                sb.Replace(symbol, '@');
            }


            return sb.ToString();
        }
    }
}
