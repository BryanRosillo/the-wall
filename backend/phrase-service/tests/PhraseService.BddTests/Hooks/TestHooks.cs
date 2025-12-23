using TechTalk.SpecFlow;

[Binding]
public class TestHooks
{
    private readonly PhraseContext _context;
    private readonly TestServer _server;

    public TestHooks(PhraseContext context, TestServer server)
    {
        _context = context;
        _server = server;
    }

    [BeforeScenario]
    public void BeforeScenario()
    {
        _context.Client = _server.CreateClient();
    }
}