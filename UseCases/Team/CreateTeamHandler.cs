using Domain.Requests;
using Infrastructure;
using Infrastructure.Repositories;
using MediatR;

namespace UseCases.Team;

internal sealed class CreateTeamHandler : IRequestHandler<CreateTeamRequest, Error?>
{
    private readonly ITeamRepository _teamRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateTeamHandler(ITeamRepository teamRepository, IUnitOfWork unitOfWork)
    {
        _teamRepository = teamRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Error?> Handle(CreateTeamRequest request, CancellationToken cancellationToken)
    {
        _teamRepository.CreateTeam(request.Team);

        await _unitOfWork.SaveChangesAsync();

        return null;
    }
}