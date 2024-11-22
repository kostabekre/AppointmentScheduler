namespace Domain.Data;

public class Meeting
{
    public Guid Id { get; set; }
    public DateTime Start { get; set; }
    public TimeSpan Duration { get; set; }
    public string? Place { get; set; }
    public IEnumerable<Employee>? Employees { get; set; }
}