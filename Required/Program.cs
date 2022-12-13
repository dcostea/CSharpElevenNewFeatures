using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using static System.Console;

var john1 = new Person { Id = 1, FirstName = "John", LastName = "Doe" };
WriteLine(john1);

var john2 = new Person(2, "John", "Doe");
//john1.Id = 2; // error
WriteLine(john2);

var anon3 = new Person(default, default!, default!);
WriteLine(anon3);

var context = new ValidationContext(anon3);
var validationResults = new List<ValidationResult>();
_ = Validator.TryValidateObject(anon3, context, validationResults, true);

class Person
{
    public required int Id { get; init; }

    [Required]
    public /*required*/ string FirstName { get; init; }

    public required string LastName { get; init; }

    public string? Description { get; init; }

    [SetsRequiredMembers]
    public Person(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    [SetsRequiredMembers]
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    [SetsRequiredMembers]
    public Person(int id)
    {
        Id = id;
    }

    //[SetsRequiredMembers()]
    public Person() 
    {
    }

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}";
    }
}
