using AppontmentSchedulerRazor.Components;
using Domain.Data;
using Domain.Requests;
using Infrastructure.Data;
using Infrastructure.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UseCases;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<AppointmentContext>(options =>
    // options.UseNpgsql("ConnectionString"));
    options.UseInMemoryDatabase("Appointment"));

builder.Services.AddMediatR(c => c.RegisterServicesFromAssemblyContaining<MediatRAssemblyMarker>());

builder.Services.AddScoped<EmployeeRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();