using System.Collections.Generic;

namespace name_sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            IFileData file = Factory.CreateFileData();
            IListSorter sorter = Factory.CreateListSorter();

            // Validate file
            bool fileValidation = file.IsValidFile(args);

            if (fileValidation == false)
            {
                file.ErrorMessage();
                return;
            }

            //Get data from file
            string[] records = file.ReadRecords(args[0]);

            //Create list people
            var peopleList = sorter.CreateList(records);

            //Sort list people
            var sortedPeopleList = sorter.SortByLastName(peopleList);

            //Covert list people to string array
            records = sorter.ConvertModelToString(sortedPeopleList);

            //Display data
            file.DisplayRecords(records);

            //Create file with sorted data
            file.WriteRecords(records);
        }
    }
}
