using static System.Console;

WriteLine("Hello C#!");

#if NET7_0

class PersonType { }

class GenericAttribute<T> : Attribute
  where T : PersonType
{
    private T _personType;
}

[GenericAttribute<PersonType>]
class Person { }

#else

class Person { }

class NonGenericAttribute : Attribute
{
    private PersonType _personType;

    public NonGenericAttribute(PersonType personType)
    {
        _personType = personType;
    }
}

[NonGenericAttribute(typeof(PersonType))]
class Person { }

#endif
