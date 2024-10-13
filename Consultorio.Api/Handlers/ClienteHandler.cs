using Consultorio.Api.Data;
using Consultorio.Core.Handlers;
using Consultorio.Core.Modelos;
using Consultorio.Core.Requests.Clientes;
using Consultorio.Core.Responses;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.Api.Handlers;

public class ClienteHandler(AppDbContext context) : IClienteHandler
{
    public async Task<Response<Cliente?>> CreateAsync(CreateClienteRequest request)
    {
        try
        {
            var cliente = new Cliente()
            {
                Nome = request.Nome,
                Endereco = request.Endereco,
                Bairro = request.Bairro,
                Cidade = request.Cidade,
                UF = request.UF,
                CEP = request.CEP,
                DataNasc = request.DataNasc,
                DataCadastro = request.DataCadastro,
                Observacao = request.Observacao,
                Empresa = request.Empresa,
                Referencia = request.Referencia,
                CPF = request.CPF,
                CarteiraPlanoSaude = request.CarteiraPlanoSaude,
                CodigoPlanoSaude = request.CodigoPlanoSaude,
                ResponsavelLegal = request.ResponsavelLegal
            };

            await context.Clientes.AddAsync(cliente);
            await context.SaveChangesAsync();   

            return new Response<Cliente?>(cliente, 201, "Cliente cadastrado com sucesso!");
        }
        // Todo: Colocar tratamento específio dbCreate...
        catch 
        {
            // Todo: Estudar Serilog
            return new Response<Cliente?>(null, 500, "Não foi possível encontrar o cliente.");
        }

    }

    public async Task<Response<Cliente?>> DeleteAsync(DeleteClienteRequest request, long codigo)
    {
        var cliente = await context.Clientes.FirstOrDefaultAsync(x => x.Codigo == codigo);

        if (cliente is null)
            return new Response<Cliente?>(null, 404, "Cliente não encontrado.");
        
        try
        {
            context.Clientes.Remove(cliente);
            await context.SaveChangesAsync();
        }
        catch 
        {
            return new Response<Cliente?>(null, 500, "Não foi possível excluir o cliente.");
        }

        return new Response<Cliente?>(cliente, 200, "Cliente excluído com sucesso!");
    }

    public async Task<Response<Cliente?>> GetClientePorCodigoAsync(GetClientePorCodigoRequest request)
    {
        try
        {
            var cliente =  await context.Clientes.AsNoTracking().FirstOrDefaultAsync(x => x.Codigo == request.Codigo);

            return cliente is null 
                ? new Response<Cliente?>(null, 404, "Cliente não encontrado.")
                : new Response<Cliente?>(cliente);
        }
        catch
        {
            return new Response<Cliente?>(null, 500, "Não foi possível encontrar o cliente.");
        }
    }

    public Task<PageResponse<Cliente>> GetTodosClientes(GetTodosClientesRequest request)
    {
        throw new NotImplementedException();
    }

    /* public async Task<PageResponse<Cliente>> GetTodosClientes(GetTodosClientesRequest request)
    {
        try
        {
            var clientes = await context.Clientes.AsNoTracking()
                .Skip(request.TamanhoPaginaPadrao * request.NumeroPaginaPadrao)
                .Take(request.TamanhoPaginaPadrao)
                .ToListAsync();

            var count = await context.Clientes.AsNoTracking().CountAsync();

            return new PageResponse<List<Cliente>>(
                clientes, 
                count, 
                request.NumeroPaginaPadrao, 
                request.TamanhoPaginaPadrao); 
        }
        catch (Exception)
        {

            throw;
        }
    } */

    public async Task<Response<Cliente?>> UpdateAsync(UpdateClienteRequest request)
    {
        var cliente = await context.Clientes.FirstOrDefaultAsync(x => x.Codigo == request.Codigo);

        if (cliente is null)
            return new Response<Cliente?>(null, 404, "Clinte não encontrado.");
        try
        {
            cliente.Nome = request.Nome;
            cliente.Endereco = request.Endereco;
            cliente.Bairro = request.Bairro;
            cliente.Cidade = request.Cidade;
            cliente.UF = request.UF;
            cliente.CEP = request.CEP;
            cliente.DataNasc = request.DataNasc;
            cliente.DataCadastro = request.DataCadastro;
            cliente.Observacao = request.Observacao;
            cliente.Empresa = request.Empresa;
            cliente.Referencia = request.Referencia;
            cliente.CPF = request.CPF;
            cliente.CarteiraPlanoSaude = request.CarteiraPlanoSaude;
            cliente.CodigoPlanoSaude = request.CodigoPlanoSaude;
            cliente.ResponsavelLegal = request.ResponsavelLegal;

            context.Clientes.Update(cliente);
            await context.SaveChangesAsync();

            return new Response<Cliente?>(cliente, mensagem:"Cliente alterado com sucesso!");
        }
        catch
        {
            return new Response<Cliente?>(null, 500, "Não foi possível alterar o cliente.");
        }
    }
}
