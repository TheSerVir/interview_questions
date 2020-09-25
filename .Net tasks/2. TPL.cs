/// <summary>
/// What pitfalls could you spot in the async code below?
/// </summary>
public class Example2
{
    private readonly AsyncService service = new AsyncService();

    public void UseServiceSynchronously()
    {
        service.PerformSomeAction().Result;
    }

    public async Task UseServiceAsynchronously()
    {
        await service.PerformSomeAction();
    }
}

public class AsyncService
{
    public async Task<bool> PerformSomeAction()
    {
        // mock a long running operation
        await Task.Delay(100);

        return true;
    }
}