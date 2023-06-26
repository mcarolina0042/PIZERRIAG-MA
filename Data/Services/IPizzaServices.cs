using PIZZASG_M.Data.Request;
using PIZZASG_M.Data.Response;

namespace PIZZASG_M.Data.Services
{
	public interface IPizzaServices
	{
		Task<Resu<List<PizzaResponse>>> Consultar(string filtro);
		Task<Resu> Crear(PizzaRequest request);
		Task<Resu> Eliminar(PizzaRequest request);
		Task<Resu> Modificar(PizzaRequest request);
	}
}