using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PeopleController : BaseController
{
    private readonly PeopleService _service;

    public PeopleController(PeopleService service)
    {
        _service = service;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GetPersonResponse>> GetPerson(string id)
    {
        var profile = await _service.GetPerson(UserId, id);
        if (profile == null)
        {
            return NotFound();
        }
        return Ok(profile);
    }

    [HttpGet]
    public async Task<ActionResult<List<GetPersonResponse>>> ListPeople()
    {
        return await _service.ListPeople(UserId);        
    }
}
