using Domain.Data;

namespace Infrastructure.Repositories;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetEmployeesAsync();
    
    void AddEmployee(Employee employee);
}