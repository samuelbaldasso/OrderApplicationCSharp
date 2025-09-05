public class PedidosServiceImpl : IPedidosService
{
  private readonly PedidosRepository _repository;

  public PedidosServiceImpl(PedidosRepository repository)
  {
    _repository = repository;
  }

  public async Task<IEnumerable<Pedidos>> GetAllAsync()
  {
    return await _repository.GetAllAsync();
  }

  public async Task AddAsync(Pedidos pedido)
  {
    await _repository.AddAsync(pedido);
  }
}
