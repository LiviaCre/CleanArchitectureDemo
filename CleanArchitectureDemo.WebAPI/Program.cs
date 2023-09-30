
using CleanArchitectureDemo.Application.Extensions;
using CleanArchitectureDemo.Infrastructure.Extensions;
using CleanArchitectureDemo.Persistence.Extensions;
using Microsoft.AspNetCore.Builder;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplicationLayer();
builder.Services.AddInfrastructureLayer();
builder.Services.AddPersistenceLayer(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
