using static System.Console;

WriteLine("Hello C#!");

struct Person
{
    // this ctor is not valid in C#10 or lower
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public int Age { get; set; } 
}

