using Infrastructure.Data;

namespace Infrastructure;

internal sealed class DbContextUnitOfWork : IUnitOfWork
{
    private readonly AppointmentContext _context;

    public DbContextUnitOfWork(AppointmentContext context)
    {
        _context = context;
    }

    public Task SaveChangesAsync()
    {
        return _context.SaveChangesAsync();
    }
}