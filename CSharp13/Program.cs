
using CSharp13;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;

Processor processor = new();
Span<string> names = ["Elena Sycheva", "Alex S", "Maria S", "Yuri S"];

var result = processor.ProcessNames("Elena Sycheva", "Alex S", "Maria S", "Yuri S");
result = processor.ProcessNames(["Elena Sycheva", "Alex S", "Maria S", "Yuri S"]);

foreach (var name in result) Console.WriteLine(name);
new LockDemo().RunSomething();
var user = new User { Name = "Elena Sycheva" };

Console.WriteLine(user.Name);
Console.WriteLine(user.Process());
public class Processor
{
    [OverloadResolutionPriority(0)]
    public IEnumerable<string> ProcessNames(params List<string> names)
    {
        foreach (var name in names)
        {
            yield return name.Split(" ")
                .First()
                .ToUpperInvariant();
        }
    }

    public IEnumerable<string> ProcessNames(params IEnumerable<string> names)
    {
        foreach (var name in names)
        {
            yield return name.Split(" ")
                .First()
                .ToUpperInvariant();
        }
    }

    [OverloadResolutionPriority(1)]
    public IEnumerable<string> ProcessNames(params ReadOnlySpan<string> names)
    {
        var result = new string[names.Length];

        for (int i = 0; i < names.Length; i++)
        {
            var name = names[i];
            result[i] = name[..name.IndexOf(" ")]
                .ToUpperInvariant();
        }

        return result;
    }

    public IEnumerable<string> ProcessNames(params Span<string> names)
    {
        var result = new string[names.Length];

        for (int i = 0; i < names.Length; i++)
        {
            var name = names[i];
            result[i] = name[..name.IndexOf(" ")]
                .ToUpperInvariant();
        }

        return result;
    }

    public IEnumerable<string> ProcessNames(params string[] names)
    {
        foreach (var name in names)
        {
            yield return name.Split(" ")
                .First()
                .ToUpperInvariant();
        }
    }
    public IEnumerable<string> ProcessNames(params ImmutableList<string> names)
    {
        foreach (var name in names)
        {
            yield return name.Split(" ")
                .First()
                .ToUpperInvariant();
        }
    }
}
public class Person
{
    public int Age {  get; set; }
    //public string Name { get => field.Trim(); set; }
}

public struct Point { 

    public int X {  get; set; } public int Y { get; set; }
    public Point(int x, int y) { X = x; Y = y; }
    public readonly double Distance(ref Person person) {
        person.Age = 23;
        return Math.Sqrt(X * X + Y * Y) * person.Age;
    }
}


