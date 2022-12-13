using Bogus;
using Bogus.DataSets;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using static System.Console;

var faker = new Faker();
Person.RandomNameGenerator = faker;

var husband = new Person(faker.Name.FirstName(Name.Gender.Male), faker.Name.LastName());
WriteLine(husband);

var wife = new Person(faker.Name.FirstName(Name.Gender.Female), faker.Name.LastName());
WriteLine(wife);

var child = husband + wife;
WriteLine(child);

WriteLine($"husband == wife ? {husband == wife}");
WriteLine($"husband != child ? {husband != child}");


public interface IPersonArthmetic<TSelf> where TSelf : IPersonArthmetic<TSelf>
{
    static abstract TSelf NewChild(string a, string b);
}

public struct Person : IPersonArthmetic<Person>,
    IAdditionOperators<Person, Person, Person>,
    IEqualityOperators<Person, Person, bool>
{
    public static Faker? RandomNameGenerator { get; set; }

    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    [SetsRequiredMembers]
    public Person(string a, string b)
    {
        FirstName = a;
        LastName = b;
    }

    public static Person NewChild(string a, string b)
    {
        return new Person
        {
            FirstName = RandomNameGenerator!.Person.FirstName,
            LastName = $"{a}-{b}"
        };
    }

    public static Person operator +(Person a, Person b) => NewChild(a.LastName, b.LastName);

    public static bool operator ==(Person left, Person right) => left.Equals(right);

    public static bool operator !=(Person left, Person right) => !left.Equals(right);

    public override bool Equals(object? other) => other is Person p && p.FirstName.Equals(FirstName) && p.LastName.Equals(LastName);

    public override string ToString() => $"{FirstName} {LastName}";

    public override int GetHashCode() => HashCode.Combine(FirstName?.GetHashCode() ?? 0, LastName?.GetHashCode() ?? 0);
}
