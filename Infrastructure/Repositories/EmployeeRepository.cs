using Domain.Data;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

internal class EmployeeRepository : IEmployeeRepository
{
    private readonly AppointmentContext _context;

    public EmployeeRepository(AppointmentContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Employee>> GetEmployeesAsync()
    {
        return await _context.Employees
            .Include(x => x.Team)
            .Include(x => x.Title)
            .AsNoTracking()
            .ToListAsync();
    }

    public void AddEmployee(Employee employee)
    {
        _context.Employees.Add(employee);
    }

    public Task SaveChangesAsync()
    {
        return _context.SaveChangesAsync();
    }
}