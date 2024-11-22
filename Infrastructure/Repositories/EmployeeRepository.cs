using Domain.Data;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class EmployeeRepository
{
    private readonly AppointmentContext _context;

    public EmployeeRepository(AppointmentContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Employee>> GetEmployeesAsync()
    {
        return await _context.Employees.ToListAsync();
    }
}