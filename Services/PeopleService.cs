
public class PeopleService
{

    internal async Task<GetPersonResponse> GetPerson(string userId, string id)
    {
        var person = new GetPersonResponse
        {
            Id = id,
            FirstName = "John",
            LastName = "Doe",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            RequestedById = userId
        };

        await Task.Delay(500);

        return person;
    }

    internal async Task<Microsoft.AspNetCore.Mvc.ActionResult<List<GetPersonResponse>>> ListPeople(string userId)
    {
        var people = new List<GetPersonResponse>
        {
            new GetPersonResponse
            {
                Id = "1",
                FirstName = "John",
                LastName = "Doe",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                RequestedById = userId
            },
            new GetPersonResponse
            {
                Id = "2",
                FirstName = "Jane",
                LastName = "Doe",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                RequestedById = userId
            }
        };

        await Task.Delay(500);

        return people;
    }
}