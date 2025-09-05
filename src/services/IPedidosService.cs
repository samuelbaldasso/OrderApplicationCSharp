using System.Collections.Generic;
using System.Threading.Tasks;

public interface IPedidosService
{
  Task<IEnumerable<Pedidos>> GetAllAsync();
  Task AddAsync(Pedidos pedido);
}
