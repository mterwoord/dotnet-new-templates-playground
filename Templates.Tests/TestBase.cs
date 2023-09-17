using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Templates.Tests;

public abstract class TestBase
{
    protected TestBase(ITestOutputHelper log)
    {
        Logger = new XunitLoggerProvider(log).CreateLogger("TestRun");
    }

    protected readonly ILogger Logger;

    protected static string GetTemplatesFolder()
    {
        var result       = typeof(TestBase).Assembly.Location;
        var codeBaseRoot = new FileInfo(result).Directory?.Parent?.Parent?.Parent?.Parent?.FullName;
        if (string.IsNullOrEmpty(codeBaseRoot))
        {
            throw new InvalidOperationException("The codebase root was not found");
        }

        codeBaseRoot = Path.Combine(codeBaseRoot, "Templates", "content");
        
        return codeBaseRoot;
    }
}