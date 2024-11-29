﻿namespace Domain.Data;

public class Team
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public IEnumerable<Employee>? Employees { get; set; }
}