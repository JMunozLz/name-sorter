using System.Collections.Generic;
using System.Linq;

namespace name_sorter
{
    public class ListSorter : IListSorter
    {
        private readonly List<IPersonModel> _personList;

        public ListSorter(List<IPersonModel> list)
        {
            this._personList = list;
        }

        public List<IPersonModel> CreateList(string[] records)
        {
            foreach (string record in records)
            {
                var person = Factory.CreatePerson();

                string[] recordSplit = record.Split(' ');

                person.GivenName = string.Join(" ", recordSplit, 0, recordSplit.Length - 1);
                person.LastName = recordSplit[recordSplit.Length - 1];

                _personList.Add(person);
            }
            return _personList;
        }

        public string[] Sort(List<IPersonModel> listRecords)
        {
            var sortedList = listRecords.OrderBy(person => person.LastName).ToList();

            return sortedList.Select(person => person.FullName.ToString()).ToArray();
        }
    }
}
