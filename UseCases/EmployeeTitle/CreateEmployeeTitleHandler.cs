using Domain.Requests;
using Infrastructure;
using Infrastructure.Repositories;
using MediatR;

namespace UseCases.EmployeeTitle;

internal sealed class CreateEmployeeTitleHandler : IRequestHandler<CreateEmployeeTitleRequest, Error?>
{
    private readonly IEmployeeTitleRepository _repository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateEmployeeTitleHandler(IEmployeeTitleRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Error?> Handle(CreateEmployeeTitleRequest request, CancellationToken cancellationToken)
    {
        _repository.AddTitle(request.Title);

        await _unitOfWork.SaveChangesAsync();

        return null;
    }
}