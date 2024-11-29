using MediatR;

namespace UseCases.EmployeeTitle;

public record GetEmployeeTitleRequest() : IRequest<IEnumerable<Domain.Data.EmployeeTitle>>;