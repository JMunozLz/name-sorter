using System.Collections.Generic;
using System.Linq;

namespace name_sorter
{
    public class ListSorter : IListSorter
    {
        private readonly List<IPersonModel> _peopleList;

        public ListSorter(List<IPersonModel> peopleList)
        {
            this._peopleList = peopleList;
        }

        public List<IPersonModel> CreateList(string[] records)
        {
            foreach (string record in records)
            {
                if (IsValidRecord(record) == false)
                {
                    continue;
                }

                var person = Factory.CreatePerson();

                string[] recordSplit = record.Split(' ');

                person.GivenName = string.Join(" ", recordSplit, 0, recordSplit.Length - 1);
                person.LastName = recordSplit[recordSplit.Length - 1];

                _peopleList.Add(person);
            }
            return _peopleList;
        }

        public List<IPersonModel> SortByLastName(List<IPersonModel> listPeople)
        {
            var listSorted = listPeople.OrderBy(person => person.LastName).ToList();

            return listSorted;
        }

        public string[] ConvertModelToString(List<IPersonModel> listPeople)
        {
            var output = listPeople.Select(person => person.FullName.ToString()).ToArray();
            return output;
        }

        public bool IsValidRecord(string record)
        {
            if (record.Length == 0)
            {
                return false;
            }

            string[] splitName = record.Split(' ');

            if (splitName.Length <= 1)
            {
                return false;
            }

            return true;
        }
    }
}
