using Domain.Data.Config;
using Infrastructure.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class RunChecks
{
    public static Task CheckDb(this WebApplication app, bool isDevelopment)
    {
        if (isDevelopment == false)
        {
            var content = app.Services.GetRequiredService<AppointmentContext>();
            return content.Database.EnsureCreatedAsync();
        }

        return Task.CompletedTask;
    }
}