namespace DatabaseDapper.Multi.Entities;

public class Customer
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public DateTime CreateAt { get; set; }
}