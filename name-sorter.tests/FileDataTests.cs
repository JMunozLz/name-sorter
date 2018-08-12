using Xunit;

namespace name_sorter.tests
{
    public class FileDataTests
    {
        [Theory]
        [InlineData("")]
        [InlineData("no-file-extension")]
        [InlineData("invalid-extension.doc")]
        public void IsValidFile_ShouldBeFalse(string fileName)
        {
            var fileData = Factory.CreateFileData();

            string[] file = { fileName };

            var validation = fileData.IsValidFile(file);

            Assert.True(validation == false);
        }

        [Fact]
        public void IsValidFile_ShouldBeTrue()
        {
            var fileData = Factory.CreateFileData();

            var fileName = "file.txt";

            string[] file = { fileName };

            var validation = fileData.IsValidFile(file);

            Assert.True(validation == true);
        }
    }
}
