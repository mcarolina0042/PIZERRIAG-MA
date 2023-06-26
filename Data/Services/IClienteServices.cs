using PIZZASG_M.Data.Request;
using PIZZASG_M.Data.Response;

namespace PIZZASG_M.Data.Services
{
	public interface IClienteServices
	{
		Task<Results<List<ClienteResponse>>> Consultar(string filtro);
		Task<Results> Crear(ClienteRequest request);
		Task<Result> Eliminar(ClienteRequest request);
		Task<Result> Modificar(ClienteRequest request);
	}
}