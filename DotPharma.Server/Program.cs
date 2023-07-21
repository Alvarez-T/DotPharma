using JasperFx.Core;
using Marten;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMarten(options =>
{
});

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
