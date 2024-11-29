using Infrastructure.Repositories;
using MediatR;

namespace UseCases.Team;

internal sealed class GetTeamsHandler : IRequestHandler<GetTeamsRequest, IEnumerable<Domain.Data.Team>>
{
    private readonly ITeamRepository _teamRepository;

    public GetTeamsHandler(ITeamRepository teamRepository)
    {
        _teamRepository = teamRepository;
    }

    public async Task<IEnumerable<Domain.Data.Team>> Handle(GetTeamsRequest request, CancellationToken cancellationToken)
    {
        var teams = await _teamRepository.GetTeamsAsync();

        return teams;
    }
}