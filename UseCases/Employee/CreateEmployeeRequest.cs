using Domain.Requests;
using MediatR;

namespace UseCases.Employee;

public record CreateEmployeeRequest(Domain.Data.Employee Employee) : IRequest<Error?>;