using Domain.Requests;
using MediatR;

namespace UseCases.Employee;

public record GetEmployeesRequest : IRequest<Result<IEnumerable<Domain.Data.Employee>>>;