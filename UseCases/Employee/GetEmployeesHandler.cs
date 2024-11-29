using Domain.Requests;
using Infrastructure.Repositories;
using MediatR;

namespace UseCases.Employee;

internal sealed class GetEmployeesHandler : IRequestHandler<GetEmployeesRequest, Result<IEnumerable<Domain.Data.Employee>>>
{
    private readonly IEmployeeRepository _repository;

    public GetEmployeesHandler(IEmployeeRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<Result<IEnumerable<Domain.Data.Employee>>> Handle(GetEmployeesRequest request, CancellationToken cancellationToken)
    {
        return new Result<IEnumerable<Domain.Data.Employee>>(await _repository.GetEmployeesAsync());
    }
}