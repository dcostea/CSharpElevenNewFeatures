namespace FileScopedTypes;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get => StringHelper.GetFullName(FirstName, LastName); }
}
