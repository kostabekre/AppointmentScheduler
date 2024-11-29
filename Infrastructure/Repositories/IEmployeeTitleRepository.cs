using Domain.Data;

namespace Infrastructure.Repositories;

public interface IEmployeeTitleRepository
{
    void AddTitle(EmployeeTitle title);
    
    Task<IEnumerable<EmployeeTitle>> GetTitlesAsync();
}