using Consultorio.Api.Data;
using Consultorio.Api.Handlers;
using Consultorio.Core.Handlers;
using Consultorio.Core.Modelos;
using Consultorio.Core.Requests.Clientes;
using Consultorio.Core.Responses;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var cnnStr = builder.Configuration.GetConnectionString("DefaultConnection") ?? String.Empty;
builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseMySQL(cnnStr);
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x => 
{
    x.CustomSchemaIds(n => n.FullName);
});
builder.Services.AddTransient<IClienteHandler, ClienteHandler>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapPost("/v1/clientes", 
    async (CreateClienteRequest request, IClienteHandler handler) 
    => await handler.CreateAsync(request))
    .WithName("Clientes: Create")
    .WithSummary("Cria um novo cliente")
    .Produces<Response<Cliente?>>();

app.MapPut("/v1/clientes/{codigo}",
    async (long codigo,
        UpdateClienteRequest request, IClienteHandler handler) => 
      {
        request.Codigo = codigo;
        return await handler.UpdateAsync(request);
    })
    .WithName("Clientes: Update")
    .WithSummary("Atualiza um cliente")
    .Produces<Response<Cliente?>>();

app.MapDelete("/v1/clientes/{codigo}",
    async (long codigo,
        IClienteHandler handler) =>
    {
        var request = new DeleteClienteRequest();
        return await handler.DeleteAsync(request, codigo);
    })
    .WithName("Clientes: Delete")
    .WithSummary("Apaga um cliente")
    .Produces<Response<Cliente?>>();

app.MapGet("/v1/clientes/{codigo}",
    async (long codigo,
        IClienteHandler handler) =>
    {

        var request = new GetClientePorCodigoRequest
        {
            Codigo = codigo
        };
        return await handler.GetClientePorCodigoAsync(request);
    })
    .WithName("Clientes: Get por código")
    .WithSummary("Retorna um cliente")
    .Produces<Response<Cliente?>>();



app.Run();



