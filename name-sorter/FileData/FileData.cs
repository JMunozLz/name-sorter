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

        public string[] ReadRecords(string inputFile)
        {
            return File.ReadAllLines(inputFile);
        }

        public void WriteRecords(string[] records)
        {
            File.WriteAllLines(@".\sorted-names-list.txt", records);
        }
    }
}
