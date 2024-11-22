using Domain.Requests;
using Infrastructure.Repositories;
using MediatR;

namespace UseCases.Employee;

public sealed class GetEmployeesHandler : IRequestHandler<GetEmployeesRequest, Result<IEnumerable<Domain.Data.Employee>>>
{
    private readonly EmployeeRepository _repository;

    public GetEmployeesHandler(EmployeeRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<Result<IEnumerable<Domain.Data.Employee>>> Handle(GetEmployeesRequest request, CancellationToken cancellationToken)
    {
        return new Result<IEnumerable<Domain.Data.Employee>>(await _repository.GetEmployeesAsync());
    }
}