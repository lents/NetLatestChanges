using TopLevel;
#region All types
//1.Type Pattern
object obj = "Hello, World!";
if (obj is string str)
{
Console.WriteLine($"String found: {str}");
}

//2.Positional Pattern
//Matches based on the deconstructed components of a type.

Point point = new(3, 4);

string result = point switch
{
(0, 0) => "Origin",
(3, 4) => "Specific point",
(_, _) => "Another point"
};

Console.WriteLine(result);
//3.Property Pattern
//Matches based on the properties of an object.

Rectangle rect = new() { Width = 10, Height = 5 };

string shape = rect switch
{
    { Width: 10, Height: 5 } => "Specific rectangle",
    { Width: > 10 } => "Wide rectangle",
    _ => "Other rectangle"
};

Console.WriteLine(shape);

//4.Tuple Pattern
//Matches based on the values in a tuple.

(int x, int y) point2 = (3, 4);

string location = point2 switch
{
    (0, 0) => "Origin",
    (3, 4) => "Specific point",
    (_, _) => "Another point"
};

Console.WriteLine(location);

//5.Relational Pattern
//Matches based on comparisons.

int number = 42;

string size = number switch
{
    < 0 => "Negative",
    <= 10 => "Small",
    <= 100 => "Medium",
    _ => "Large"
};

Console.WriteLine(size);
//6. "and" Pattern
//Combines multiple conditions with logical AND.

number = 50;

result = number switch
{
    > 0 and < 100 => "Positive and less than 100",
    _ => "Other"
};

Console.WriteLine(result);
//7. "or" Pattern
//Combines multiple conditions with logical OR.
number = -5;

result = number switch
{
    < 0 or > 100 => "Outside range 0-100",
    _ => "Inside range 0-100"
};

Console.WriteLine(result);
//8. "not" Pattern
//Negates a condition.

obj = 42;

result = obj switch
{
    not string => "Not a string",
    _ => "It's a string"
};

Console.WriteLine(result);
//9.List Pattern
//Matches elements in a list or array.


int[] numbers = { 1, 2, 3 };

result = numbers switch
{
[1, 2, 3] => "Exact match",
[1, 2, _] => "Starts with 1, 2",
    _ => "Other"
};

Console.WriteLine(result);
//10.Parenthesized Pattern
//Groups patterns for clarity or precedence.


number = 42;

result = number switch
{
    (>= 0 and <= 10) or (>= 40 and <= 50) => "In range",
    _ => "Out of range"
};

Console.WriteLine(result);
//11.Recursive Pattern
//Matches recursively on nested objects or structures.

Node linkedList = new("Head", new("Middle", new("Tail", null)));

result = linkedList switch
{
    { Next: { Next: { Value: "Tail" } } } => "Has at least three nodes",
    _ => "Fewer nodes"
};

Console.WriteLine(result);
// Output: Has at least three nodes
#endregion

#region Base Patterns
TestResult testResult = GetResult();
//if (GetResult() is Passed { TestDate.Year: >= 2022 and <= 2023 } theTest)
//{
//    theTest.
//}

var outcome = testResult switch
{
    Passed { TestDate.Year: >= 2022 and <= 2023 } => "Retake",
    Passed passed => "P",
    Failed failed => "F",
    _ => ""
};

TestResult GetResult()
{
    var test = new Failed(3, DateTimeOffset.MinValue);
    test = test with { NumberOfAttempts = 6 };
    return test;
}
#endregion
#region List & Slice Patterns

byte[] payload = new byte[] { 0x02, 0xf1, 0xaa, 0xf2, 0x23, 0xff };

#region Pattern matching

var result1 = payload switch
{
[0x02, .. var slice] data => Process(data, slice),
[0x03, _, .. var slice] data => Process(data, slice),
[0x04, _, _, .. var slice] data => Process(data, slice),
[] or [..] => 0x00
};


#endregion

#region Completed
//    [0x02, .. var slice] data => Process(data, slice),
//    [0x03, _, .. var slice] data => Process(data, slice),
//    [0x04, _, _, .. var slice] data => Process(data, slice),
//    [] or [..] => 0x00,
//    _ => throw new NotImplementedException()
#endregion

Console.WriteLine($"0x{result:x}");

Console.ReadLine();

byte Process(Span<byte> collection, Span<byte> slice)
{
    return slice[0];
}

#endregion

public record Point(int X, int Y);

public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }
}

public record Node(string Value, Node? Next);

