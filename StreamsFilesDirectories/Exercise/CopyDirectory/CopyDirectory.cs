namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath =  @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            Directory.CreateDirectory(outputPath);
            var files = Directory.GetFiles(inputPath);
            
            foreach (var file in files) 
            { 
                File.Copy(file, Path.Combine(outputPath, Path.GetFileName(file)));
            }

            foreach (var directory in Directory.GetDirectories(inputPath)) 
            {
                CopyAllFiles(directory, Path.Combine(outputPath, Path.GetFileName(directory)));
            }
        }
    }
}
