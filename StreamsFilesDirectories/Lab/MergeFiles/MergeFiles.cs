namespace MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            var firstFile = File.ReadAllLines(firstInputFilePath);  
            var secondFile = File.ReadAllLines(secondInputFilePath);

            File.WriteAllText(outputFilePath, string.Empty);

            for (int i = 0; i < firstFile.Length; i++)
            {
                File.AppendAllText(outputFilePath, firstFile[i] +
                                                   Environment.NewLine +
                                                   secondFile[i] +
                                                   Environment.NewLine);
            }
        }
    }
}
