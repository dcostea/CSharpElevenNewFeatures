namespace FileScopedTypes;

// file keyword introduced in C#11
file static class StringHelper
{
    public static string GetFullName(string firstName, string lastName)
    {
        return $"Mr. {firstName} {lastName}";
    }
}

class Teacher
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get => StringHelper.GetFullName(FirstName, LastName); }
}
