namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(wordsFilePath))
            {
                var words = new List<string>();

                while (true) 
                {
                   string line = reader.ReadLine();

                    if (line == null) 
                    {
                        break;
                    }

                    words.Add(line);
                }

                using (StreamReader readText = new StreamReader(textFilePath))
                {
                    char[] separators = new char[]
                    { '-','.',',','?','\'', '!',' '};

                    List<string> text = new List<string>();

                    while (true) 
                    {
                        string line = readText.ReadLine();

                        if (line == null) { break; }

                        text.AddRange(line.ToLower().Split(separators));  
                    }

                    Dictionary<string, int> wordsCount = new Dictionary<string, int>();

                    foreach (string word in words) 
                    {
                        if (!wordsCount.ContainsKey(word)) 
                        {
                           wordsCount.Add(word, 0);
                        
                        }

                        
                        while (text.Contains(word)) 
                        {
                            wordsCount[word]++;
                            text.RemoveAt(text.IndexOf(word));
                        }

                        

                    
                    }

                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        foreach(var dictionary in wordsCount.OrderByDescending(x => x.Value)) 
                        {
                            writer.WriteLine($"{dictionary.Key} - {dictionary.Value}");
                        }
                    }
                }

            }
        }
    }
}
