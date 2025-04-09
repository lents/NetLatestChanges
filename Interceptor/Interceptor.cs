using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Interceptors;

public static class Interceptor
{
    [DebuggerHidden]
    [InterceptsLocation
        (@"D:\Projects\OTUS\NetLatestChanges\Interceptor\Logger.cs", 4, 9)]
    public static void DebugLog(this Logger logger, string message)
    {
        Console.WriteLine(message);
    }
}