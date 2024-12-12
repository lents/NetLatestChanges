var attribute = Attribute.GetCustomAttribute(
    typeof(MyClass), typeof(TypeAttribute<int>)
) as TypeAttribute<int>;

Console.WriteLine(attribute?.Description);

public class TypeAttribute<T> : Attribute
{
    public string Description { get; }

    public TypeAttribute(string description)
    {
        Description = $"{description} type {typeof(T)}";
    }
}

[TypeAttribute<int>("This is an integer type")]
public class MyClass
{
}


