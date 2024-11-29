using Domain.Data;

namespace Infrastructure.Repositories;

public interface ITeamRepository
{
    void CreateTeam(Team team);
    
    Task<IEnumerable<Team>> GetTeamsAsync();
}