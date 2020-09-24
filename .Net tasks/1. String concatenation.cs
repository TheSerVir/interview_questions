public class Example1
{
    /// <summary>
    /// What's wrong about this concatenation implementation?
    /// </summary>
    public string ConcatStrings(params string[] itemsToConcat)
    {
        var result = string.Empty;

        foreach (var item in itemsToConcat)
        {
            result += item;
        }

        return result;
    }
}