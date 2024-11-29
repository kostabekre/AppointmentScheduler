using Domain.Requests;
using MediatR;

namespace UseCases.EmployeeTitle;

public record CreateEmployeeTitleRequest(Domain.Data.EmployeeTitle Title) : IRequest<Error?>;