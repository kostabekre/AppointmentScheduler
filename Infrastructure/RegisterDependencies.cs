using Domain.Data.Config;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class RegisterDependencies
{
    public static IServiceCollection AddDataBase(this IServiceCollection collection, bool isDevelopment, DbConnection dbConnection)
    {
        if (isDevelopment)
        {
            collection.AddDbContext<AppointmentContext>(options =>
                options.UseInMemoryDatabase("Appointment"));
        }
        else
        {
            collection.AddDbContext<AppointmentContext>(options =>
                options.UseNpgsql(dbConnection.ConnectionString));
        }

        return collection;
    }

    public static IServiceCollection AddRepositories(this IServiceCollection collection)
    {
        collection.AddScoped<IEmployeeRepository, EmployeeRepository>();
        collection.AddScoped<ITeamRepository, TeamRepository>();
        collection.AddScoped<IEmployeeTitleRepository, EmployeeTitleRepository>();
        collection.AddScoped<IUnitOfWork, DbContextUnitOfWork>();

        return collection;
    }
}