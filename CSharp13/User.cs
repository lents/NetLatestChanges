using System.Diagnostics.CodeAnalysis;
public partial class User
{
    private string? name;
    public partial string Name
    {
        get => name.ToUpperInvariant();
        set => name = value;
    }

    //[Experimental("MyTest")]
    public partial string Process()
    {
        return string.Join("", Name.Reverse());
    }
}