using System.Collections.Generic;

namespace name_sorter
{
    public interface IListSorter
    {
        List<IPersonModel> CreateList(string[] records);
        string[] Sort(List<IPersonModel> listRecords);
    }
}
