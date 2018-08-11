using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace name_sorter.tests
{
    public class ListSorterTests
    {
        [Fact]
        public void CreateList_ShouldWork()
        {
            var sorter = Factory.CreateListSorter();
            string[] input = { "John David Doe" };
            var expected = new List<IPersonModel>
            {
                new PersonModel { GivenName = "John David", LastName = "Doe" }
            };

            var actual = sorter.CreateList(input);

            Assert.Equal(expected[0].GivenName, actual[0].GivenName);
            Assert.Equal(expected[0].LastName, actual[0].LastName);
            Assert.Equal(expected[0].FullName, actual[0].FullName);
        }

        [Fact]
        public void SortByLastName_ShouldWork()
        {
            var sorter = Factory.CreateListSorter();
            var input = new List<IPersonModel>
            {
                new PersonModel { GivenName = "Michael", LastName = "Wang" },
                new PersonModel { GivenName = "John", LastName = "Doe" }
            };
            var expected = new List<IPersonModel>
            {
                new PersonModel { GivenName = "John", LastName = "Doe" },
                new PersonModel { GivenName = "Michael", LastName = "Wang" }
            };

            var actual = sorter.SortByLastName(input);

            Assert.Equal(expected[0].FullName, actual[0].FullName);
        }

        [Fact]
        public void ConvertModelToString_ShouldWork()
        {
            var sorter = Factory.CreateListSorter();
            var input = new List<IPersonModel>
            {
                new PersonModel { GivenName = "John", LastName = "Doe" }
            };
            string[] expected = { "John Doe" };

            var actual = sorter.ConvertModelToString(input);

            Assert.Equal(expected[0], actual[0]);
        }
    }
}
