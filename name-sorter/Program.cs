using System.Collections.Generic;

namespace name_sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            IFileData file = Factory.CreateFileData();
            IListSorter sorter = Factory.CreateListSorter();

            //Get data from file
            string[] records = file.ReadRecords(args[0]);
            //string[] records = file.ReadRecords(@"D:\Proyectos Visual\name-sorter\name-sorter\unsorted-names-list.txt");

            //Create list person
            List<IPersonModel> personList = sorter.CreateList(records);
            //Sort list person
            records = sorter.Sort(personList);
            //Display data
            file.DisplayRecords(records);
            //Create file with sorted data
            file.WriteRecords(records);
        }
    }
}
