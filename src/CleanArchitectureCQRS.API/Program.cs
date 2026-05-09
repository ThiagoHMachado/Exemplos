
using CleanArchitectureCQRS.Application.Commands;
using CleanArchitectureCQRS.Application.Interfaces;
using CleanArchitectureCQRS.Application.Queries;
using CleanArchitectureCQRS.CrossCutting;
using CleanArchitectureCQRS.Infrastructure.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

// Add services to the container.

var builder = WebApplication.CreateBuilder(args);
foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
{
    builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(assembly));
}
builder.Services.AddMediatR(cfg =>
{

    cfg.RegisterServicesFromAssembly(typeof(CriarClienteCommand).Assembly);    
});
builder.Services.AddAutoMapper(c => { c.AddProfile(typeof(AutoMapperProfile)); });
builder.Services.AddCache();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddService();
builder.Services.AddContext(connectionString);
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); // Disponível em http://localhost:<porta>/swagger
}
app.UseHttpsRedirection();

app.MapControllers();



//app.MapPost("/clientes", async (CriarClienteCommand cmd, IMediator mediator) =>
//{
//    var id = await mediator.Send(cmd);
//    return Results.Ok(id);
//});

//app.MapGet("/clientes/{id}", async (int Id, IMediator mediator) =>
//{
//    var result = await mediator.Send(new ObterClienteQuery(Id));
//    return Results.Ok(result);
//});

app.Run();




