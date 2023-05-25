namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string filesPath = @"../../../Files/TestFolder";
            string outputPath = @"../../../output.txt";

           GetFolderSize(filesPath, outputPath);

        }

        public static void GetFolderSize(string filesPath, string outputPath)
        {
            double sum = 0; 
            DirectoryInfo dir = new DirectoryInfo(filesPath);
            FileInfo[] files = dir.GetFiles("*", SearchOption.AllDirectories);

            foreach (FileInfo file in files) 
            {
                sum += file.Length;
            }

            sum = sum / 1024.00;

            File.WriteAllText(outputPath, $"{sum.ToString()} KB");
        }
    }

}
