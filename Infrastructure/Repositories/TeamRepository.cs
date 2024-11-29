using Domain.Data;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

internal sealed class TeamRepository : ITeamRepository
{
    private readonly AppointmentContext _context;

    public TeamRepository(AppointmentContext context)
    {
        _context = context;
    }

    public void CreateTeam(Team team)
    {
        _context.Add(team);
    }

    public async Task<IEnumerable<Team>> GetTeamsAsync()
    {
        return await _context.Teams
            .AsNoTracking()
            .ToListAsync();
    }
}