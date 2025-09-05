using Microsoft.EntityFrameworkCore;

public class PedidosRepositoryImpl : PedidosRepository
{
    private readonly AppDbContext _context;

    public PedidosRepositoryImpl(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Pedidos>> GetAllAsync()
    {
        return await _context.Pedidos.ToListAsync();
    }

    public async Task AddAsync(Pedidos pedido)
    {
        await _context.Pedidos.AddAsync(pedido);
        await _context.SaveChangesAsync(); 
    }
}
