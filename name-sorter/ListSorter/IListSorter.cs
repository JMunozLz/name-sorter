using System.Collections.Generic;

namespace name_sorter
{
    public interface IListSorter
    {
        List<IPersonModel> CreateList(string[] records);
        List<IPersonModel> SortByLastName(List<IPersonModel> listPeople);
        string[] ConvertModelToString(List<IPersonModel> listPeople);
        bool IsValidRecord(string record);
    }
}
