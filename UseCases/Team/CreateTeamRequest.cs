using Domain.Requests;
using MediatR;

namespace UseCases.Team;

public record CreateTeamRequest(Domain.Data.Team Team) : IRequest<Error?>;