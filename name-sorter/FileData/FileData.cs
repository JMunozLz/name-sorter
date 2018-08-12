using System;
using System.IO;

namespace name_sorter
{
    public class FileData : IFileData
    {
        public void DisplayRecords(string[] records)
        {
            Console.WriteLine("-----------------------");
            foreach (string record in records)
            {
                Console.WriteLine(record);
            }
        }

        public bool IsValidFile(string[] file)
        {
            if (file.Length == 0)
            {
                return false;
            }

            string validExt = ".txt";
            string fileExt = Path.GetExtension(file[0]);

            bool validation = validExt.Equals(fileExt);

            if (validation == false)
            {
                return false;
            }

            return true;
        }

        public string[] ReadRecords(string inputFile)
        {
            return File.ReadAllLines(inputFile);
        }

        public void WriteRecords(string[] records)
        {
            File.WriteAllLines(@".\sorted-names-list.txt", records);
        }

        public void ErrorMessage()
        {
            Console.WriteLine("Invalid file");
        }
    }
}
