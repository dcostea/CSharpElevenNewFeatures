using System;
using static System.Console;

var john = new Person { FirstName = "John", LastName = "Doe" };
WriteLine(john.GetFullName());
WriteLine(Person.Type());

interface IPerson
{
    string FirstName { get; init; }
    string LastName { get; init; }

    string GetFullName();

    static abstract string Type();
}

class Person : IPerson
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }

    public static string Type()
    {
        return nameof(Person);
    }

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}

