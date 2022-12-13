using FileScopedTypes;
using static System.Console;

var teacher = new Teacher { FirstName = "Steve", LastName = "Gordon" };
WriteLine(teacher.FullName);

var student = new Student { FirstName = "John", LastName = "Smith" };
WriteLine(student.FullName);

public static class StringHelper
{
    public static string GetFullName(string firstName, string lastName)
    {
        return $"{firstName} {lastName}";
    }
}
