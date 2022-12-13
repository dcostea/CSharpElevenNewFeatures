using static System.Console;

var hello = "Hello";

#if NET7_0

ReadOnlySpan<char> spanHello = hello.AsSpan();
if (strSpan is hello)
{
    Console.WriteLine($"{hello} is {spanHello} in C#11");
}

#else

ReadOnlySpan<char> spanHello = hello.AsSpan();
if (spanHello == hello)
{
    Console.WriteLine($"{hello} is {spanHello} below C#11");
}

#endif
