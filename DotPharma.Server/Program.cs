using JasperFx.Core;
using Wolverine;
using Marten;
using Wolverine.Http;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMarten(options =>
{
});

builder.Host.UseWolverine(opts =>
{
    opts.Discovery.IncludeAssembly(typeof(Program).Assembly);
});

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

app.MapWolverineEndpoints();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
