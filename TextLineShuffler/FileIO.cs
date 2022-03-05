using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace TextLineShuffler
{
    class FileIO
    {
        public static bool CheckFileExists(string fileName)
        {
            bool exists;
            if (File.Exists(fileName))
            {
                exists = true;
            }
            else
            {
                exists = false;
            }
            return (exists);
        }

        public static string ShuffleFile(string fileName)
        {
            int shuffles = 7;
            List<string> contents = GetFileContents(fileName);

            for(int i = 0; i < shuffles; i++)
            {
                contents = ShuffleList(contents);
            }

            string newFileName = WriteToNewFile(contents, fileName);
            return newFileName;
        }

        public static List<string> ShuffleList(List<string> orderedList)
        {
            Random rnd = new Random();
            List<string> randomizedList = orderedList.OrderBy(item => rnd.Next()).ToList();

            return (randomizedList);
        }
        public static List<string> GetFileContents(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            string line = reader.ReadLine();
            List<string> fileContents = new List<string>();
            do
            {
                fileContents.Add(line);
                line = reader.ReadLine();
            } while (line != null);
            reader.Close();
            return fileContents;
        }
        public static string WriteToNewFile(List<string> contents, string fileName)
        {
            fileName = "Shuffled_" + fileName;
            StreamWriter writer = new StreamWriter(fileName);
            foreach(string line in contents)
            {
                writer.Write(line + Environment.NewLine);
            }
            writer.Close();
            return (fileName);
        }
    }
}
