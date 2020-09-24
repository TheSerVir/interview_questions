public class Example2
{
    /// <summary>
    /// What's wrong about this synchronous task execution?
    /// </summary>
    public TResult ExecuteSynchroniously<TResult>(Func<Task<TResult>> asyncAction)
    {
        return asyncAction().Result;
    }

    /// <summary>
    /// How is this "LogAsyncActionExecution1" different from "LogAsyncActionExecution2".
    /// What's going on under the hood?
    /// </summary>
    public async Task LogAsyncActionExecution(Func<Task> asyncAction)
    {
        Debug.WriteLine("Running an async action.");

        await asyncAction();
    
        Debug.WriteLine("Finished the execution of the async action.");
    }

    public async Task LogAsyncActionExecution2(Func<Task> asyncAction)
    {
        Debug.WriteLine("Running an async action.");

        await asyncAction().ConfigureAwait(false);
    
        Debug.WriteLine("Finished the execution of the async action.");
    }
}