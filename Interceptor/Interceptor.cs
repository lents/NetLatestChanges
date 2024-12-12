using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Interceptors;

public static class Interceptor
{
    [DebuggerHidden]
    [InterceptsLocation
        (@"C:\Users\Elena\source\repos\NetLatestChanges\Interceptor\Logger.cs", 7, 9)]
    public static void DebugLog(this Logger logger, string message)
    {
        Console.WriteLine(message);
    }
}