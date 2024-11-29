using Domain.Data;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

internal sealed class EmployeeTitleRepository : IEmployeeTitleRepository
{
    private readonly AppointmentContext _context;

    public EmployeeTitleRepository(AppointmentContext context)
    {
        _context = context;
    }

    public void AddTitle(EmployeeTitle title)
    {
        _context.Titles.Add(title);
    }

    public async Task<IEnumerable<EmployeeTitle>> GetTitlesAsync()
    {
        return await _context.Titles
            .AsNoTracking()
            .ToListAsync();
    }
}