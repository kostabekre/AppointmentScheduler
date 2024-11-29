namespace Domain.Data;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;

    public int TitleId { get; set; }
    public EmployeeTitle? Title { get; set; } = null!;

    public int TeamId { get; set; }
    public Team? Team { get; set; } = null!;
}