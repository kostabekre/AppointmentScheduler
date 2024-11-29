using MediatR;

namespace UseCases.Team;

public record GetTeamsRequest() : IRequest<IEnumerable<Domain.Data.Team>>;