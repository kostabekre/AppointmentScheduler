using Domain.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class AppointmentContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    
    public AppointmentContext(DbContextOptions<AppointmentContext> contextOptions) : base(contextOptions)
    {
        
    }
}