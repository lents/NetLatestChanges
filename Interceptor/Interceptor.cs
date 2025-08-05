using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Interceptors;

public static class Interceptor
{
    [DebuggerHidden]
    [InterceptsLocation
        (@"D:\Projects\OTUS\NetLatestChanges\Interceptor\Program.cs", 5, 8)]
    public static void Log(this Logger logger, string message)
    {
        Console.WriteLine(message);
    }
}