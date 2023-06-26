using PIZZASG_M.Data.Request;
using PIZZASG_M.Data.Response;

namespace PIZZASG_M.Data.Services
{
	public interface IFacturaServices
	{
		Task<Resul<List<FacturaResponse>>> Consultar(string filtro);
		Task<Resul> Crear(FacturaRequest request);
		Task<Resul> Eliminar(FacturaRequest request);
		Task<Resul> Modificar(FacturaRequest request);
	}
}