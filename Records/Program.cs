namespace Records
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        record TestResult(int NumberOfAttempts, DateTimeOffset TestDate);
        record Passed(int NumberOfAttempts, DateTimeOffset TestDate): TestResult(NumberOfAttempts, TestDate);
        record Failed(int NumberOfAttempts, DateTimeOffset TestDate) : TestResult(NumberOfAttempts, TestDate);
    }
}
