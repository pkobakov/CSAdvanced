namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);  
            StringBuilder stringBuilder = new StringBuilder();


            for (int i = 0; i < lines.Length; i++)
            {

                int lettersCount = 0;   
                int punctoationCount = 0;

                char[] letters = lines[i].ToCharArray();
                lettersCount = letters.Where(x => char.IsLetter(x)).Count();
                punctoationCount = letters.Where(x => char.IsPunctuation(x)).Count();
                stringBuilder.AppendLine($"Line {i+1}: {lines[i]} ({lettersCount})({punctoationCount})");
            }



           File.AppendAllText( outputFilePath, stringBuilder.ToString() );  
        }
    }
}
