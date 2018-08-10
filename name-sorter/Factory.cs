using System.Collections.Generic;

namespace name_sorter
{
    public static class Factory
    {
        public static IFileData CreateFileData()
        {
            return new FileData();
        }

        public static IListSorter CreateListSorter()
        {
            return new ListSorter(CreatePersonList());
        }

        public static IPersonModel CreatePerson()
        {
            return new PersonModel();
        }

        public static List<IPersonModel> CreatePersonList()
        {
            return new List<IPersonModel>();
        }
    }
}
