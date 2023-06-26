using PIZZASG_M.Data.Models;
using PIZZASG_M.Data.Request;

namespace PIZZASG_M.Data.Response
{
    public class ClienteResponse
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public ClienteRequest ToRequest() 
        {
            return new ClienteRequest 
            { 
                Id = Id, 
                Nombre = Nombre 
            };

		}
    }
}
