using PIZZASG_M.Data.Request;
using PIZZASG_M.Data.Response;

namespace PIZZASG_M.Data.Services
{
	public interface IUsuarioServices
	{
		Task<Res<List<UsuarioResponse>>> Consultar(string filtro);
		Task<Res> Crear(UsuarioRequest request);
		Task<Res> Eliminar(UsuarioRequest request);
		Task<Res> Modificar(UsuarioRequest request);
	}
}