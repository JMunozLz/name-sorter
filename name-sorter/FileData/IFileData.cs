namespace name_sorter
{
    public interface IFileData
    {
        void DisplayRecords(string[] records);
        string[] ReadRecords(string inputFile);
        void WriteRecords(string[] outputFile);
    }
}
