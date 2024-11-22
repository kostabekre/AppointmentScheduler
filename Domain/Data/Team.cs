namespace Domain.Data;

public class Team
{
    public string Name { get; set; } = null!;
    public IEnumerable<Employee>? Employees { get; set; }
}