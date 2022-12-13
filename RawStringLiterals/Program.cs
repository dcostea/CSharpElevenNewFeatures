using System.Text;
using static System.Console;

// raw string literals

var json = "{\r\n  \"firstName\": \"John\",\r\n  \"lastName\": \"Smith\"\r\n}";
WriteLine(json);

var json1 = @"{
  ""firstName"": ""John"",
  ""lastName"": ""Smith""
}";
WriteLine(json1);

var json2 = """"
            {
              "firstName": "John """ ",
              "lastName": "Smith"
            }
    """";
WriteLine(json2);

var firstName = "Steve";
var lastName = "Gordon";
var json3 = $$"""
{
  "firstName": "{{firstName}}",
  "lastName": "{{lastName}}"
}
""";
WriteLine(json3);

// string interpolation newline
var name = "Scott";
var prefix = "Mr.";
var message = $"This is {(
    prefix.Length < 5
        ? prefix + name
        : prefix[0..5] + name
    )}!";
WriteLine(message);

// UTF8 string literals

byte[] array0 = Encoding.Unicode.GetBytes("John");
WriteLine(string.Join(" ", array0));

byte[] array1 = Encoding.UTF8.GetBytes("John");
WriteLine(string.Join(" ", array1));

ReadOnlySpan<byte> array2 = "John"u8;
WriteLine(string.Join(" ", array2.ToArray()));
