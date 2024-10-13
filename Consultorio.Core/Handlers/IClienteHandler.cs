using Consultorio.Core.Modelos;
using Consultorio.Core.Requests.Clientes;
using Consultorio.Core.Responses;

namespace Consultorio.Core.Handlers;

public interface IClienteHandler
{
    Task<Response<Cliente?>> CreateAsync(CreateClienteRequest request);
    Task<Response<Cliente?>> UpdateAsync(UpdateClienteRequest request);
    Task<Response<Cliente?>> DeleteAsync(DeleteClienteRequest request, long codigo);
    Task<Response<Cliente?>> GetClientePorCodigoAsync(GetClientePorCodigoRequest request);
    Task<PageResponse<Cliente>> GetTodosClientes(GetTodosClientesRequest request);

}
