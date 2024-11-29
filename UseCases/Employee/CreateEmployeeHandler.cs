using Domain.Requests;
using Infrastructure;
using Infrastructure.Repositories;
using MediatR;

namespace UseCases.Employee;

internal sealed class CreateEmployeeHandler : IRequestHandler<CreateEmployeeRequest, Error?>
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateEmployeeHandler(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork)
    {
        _employeeRepository = employeeRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Error?> Handle(CreateEmployeeRequest request, CancellationToken cancellationToken)
    {
        _employeeRepository.AddEmployee(request.Employee);

        await _unitOfWork.SaveChangesAsync();

        return null;
    }
}