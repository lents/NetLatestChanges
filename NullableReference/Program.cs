namespace NullableReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person { Details = new Details { FirstName="@"} };
            Console.WriteLine(person.Details.LastName.Length);
        }

        public class Person { 
            public required Details Details { get; set; }            
        }
    }

    public class Details
    {
        public required string FirstName {  get; init; }
        public string? LastName { get; set; }
    }
}
