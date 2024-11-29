using Domain.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

internal class AppointmentContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Team> Teams { get; set; }
    
    public DbSet<EmployeeTitle> Titles { get; set; }
    
    public AppointmentContext(DbContextOptions<AppointmentContext> contextOptions) : base(contextOptions)
    {
        
    }
}