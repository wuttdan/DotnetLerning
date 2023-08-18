namespace miniEAI.ConsoleApp.CoreTest;

public abstract class ApplicationTestBase : IApplicationTest
{
    protected readonly ILogger _logger;

    protected ApplicationTestBase(ILogger logger)
    {
        _logger = logger;
    }

    public virtual Task Run(params string[] args)
    {
        throw new NotImplementedException();
    }
}
