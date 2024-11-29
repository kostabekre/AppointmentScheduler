using AppointmentSchedulerRazor.Components;
using Domain.Data.Config;
using Infrastructure;
using UseCases;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var dbConnectionOptions = builder.Configuration.GetSection(DbConnection.Position).Get<DbConnection>();

if (dbConnectionOptions == null)
{
    throw new NullReferenceException("Configuration not founded");
}

builder.Services.AddDataBase(builder.Environment.IsDevelopment(), dbConnectionOptions);

builder.Services.AddRepositories();

builder.Services.AddMediatR(c => c.RegisterServicesFromAssemblyContaining<MediatRAssemblyMarker>());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


await app.CheckDb(app.Environment.IsDevelopment());

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();