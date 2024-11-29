using Infrastructure.Repositories;
using MediatR;

namespace UseCases.EmployeeTitle;

internal sealed class GetEmployeeTitleHandler : IRequestHandler<GetEmployeeTitleRequest, IEnumerable<Domain.Data.EmployeeTitle>>
{
    private readonly IEmployeeTitleRepository _repository;

    public GetEmployeeTitleHandler(IEmployeeTitleRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Domain.Data.EmployeeTitle>> Handle(GetEmployeeTitleRequest request, CancellationToken cancellationToken)
    {
        return await _repository.GetTitlesAsync();
    }
}