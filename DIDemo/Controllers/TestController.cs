using DIDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace DIDemo.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
    private readonly MySingletonService _singleton;
    private readonly MyTransientTestService _transient;
    private readonly MyScopedService _scoped;

    public TestController(MySingletonService singleton, MyTransientTestService transient, MyScopedService scoped)
    {
        _singleton = singleton;
        _transient = transient;
        _scoped = scoped;
    }

    [HttpGet("singleton")]
    public string TestSingleton()
    {
        return _singleton.GetName();
    }

    [HttpGet("transient in scoped")]
    public string TestScoped()
    {
        return _scoped.GetTransientName();
    }

    [HttpGet("scoped in transient")]
    public string TestTrasient()
    {
        return _transient.GetScopedName();
    }
}
