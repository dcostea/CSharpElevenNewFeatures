using static System.Console;

WriteLine("Hello C#!");


[AttributeUsage(AttributeTargets.All)]
public class PolitenessAttribute : Attribute
{
    private readonly string _prefix;

    public PolitenessAttribute(string prefix)
    {
        _prefix = prefix;
    }

    public string Prefix
    {
        get { return _prefix; }
    }
}

public class Person
{
    // this attribute argument is not valid in C#10 or lower
    [Politeness(nameof(prefix))]
    public static string GetFirstName(string prefix, [Politeness(nameof(prefix))] string fullName)
    {
        // get prefix from attribute using reflection
        return prefix + fullName.Split(" ").First();
    }
}

