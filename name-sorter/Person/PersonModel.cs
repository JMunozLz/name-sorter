namespace name_sorter
{
    public class PersonModel : IPersonModel
    {
        private string givenName;
        private string lastName;

        public string GivenName
        {
            get { return givenName; }
            set { givenName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FullName
        {
            get
            {
                return $"{givenName} {lastName}";
            }
        }
    }
}