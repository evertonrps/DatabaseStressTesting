namespace DatabaseEF.Entitites;

public class Lead : Entity<Lead>
{
    public Lead()
    {
            
    }
    public string Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
