public class GetPersonResponse
{
    public required string Id { get; set; }
    public string? FirstName { get; set; }
    public  string? LastName { get; set; }
    public DateTime CreatedAt { get; set; } 
    public DateTime UpdatedAt { get; set; }
    public string? RequestedById { get; set; }
}
