/// <summary>
/// How does routing work for this controller?
/// Which HTTP verbs does it support?
/// </summary>
[RoutePrefix("api/resource")]
public class Example3Controller : ApiController
{
    private readonly ISomeMagic magic;

    public Example3Controller(ISomeMagic magic)
    {
        this.magic = magic;
    }

    [HttpPatch]
    [Route("{resourceId}")]
    public async Task<IHttpActionResult> ModifyResource(
        string resourceId,
        ResourceChangeDescription changes)
    {
        return Ok(await magic.Away(changes));
    }

    [Route("{resourceId}")]
    public async Task<IHttpActionResult> PutResource(
        string resourceId,
        ResourceFullModification model)
    {
        return Ok(await magic.Turn(model));
    }

    public async Task<IHttpActionResult> PostResource(ResourceCreation model)
    {
        var resource = await magic.Into(model);
        return Created($"api/resource/{resource.Id}", resource);
    }

    [HttpGet]
    [Route("{resourceId}")]
    public async Task<IHttpActionResult> FindResource(string resourceId)
    {
        return Ok(await magic.Wow(resourceId));
    }
}

public class ResourceChangeDescription
{
    public string AnyValue { get; set; }
}

public class ResourceFullModification
{
    public int Prop1 { get; set; }

    public int Prop2 { get; set; }
}

public class ResourceCreation
{
    public int Prop1 { get; set; }

    public int Prop2 { get; set; }
}