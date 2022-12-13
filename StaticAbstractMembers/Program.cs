using static System.Console;

WriteLine(Person.GetClassType());

var john = new Person { FirstName = "Steve", LastName = "Smith" };
var jane = new Person { FirstName = "Scott", LastName = "Ford" };
WriteLine(john.GetFullName());
WriteLine(jane.GetFullName());

Person.Anonymize<Person>(john, jane);
WriteLine(john.GetFullName());
WriteLine(jane.GetFullName());

interface IPerson
{
    string FirstName { get; set; }
    string LastName { get; set; }

    string GetFullName();
    static abstract string GetClassType();
    static abstract void Anonymize<T>(params T[] persons) where T : IPerson;
}

class Person : IPerson
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    // abstract static
    public static string GetClassType()
    {
        return nameof(Person);
    }

    // generic abstract static
    public static void Anonymize<T>(params T[] persons) where T : IPerson
    {
        foreach (T person in persons)
        {
            person.LastName = "Doe";
            person.FirstName = "John";
        }
    }

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}
