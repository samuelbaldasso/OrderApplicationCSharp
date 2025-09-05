public interface PedidosRepository
{
    Task<IEnumerable<Pedidos>> GetAllAsync();
    Task AddAsync(Pedidos pedido);
}
