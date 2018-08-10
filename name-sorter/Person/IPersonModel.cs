namespace name_sorter
{
    public interface IPersonModel
    {
        string FullName { get; }
        string GivenName { get; set; }
        string LastName { get; set; }
    }
}