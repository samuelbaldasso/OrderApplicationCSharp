using Microsoft.EntityFrameworkCore;

public class PedidosRepositoryImplTests
{
  private AppDbContext GetDbContext()
  {
    var options = new DbContextOptionsBuilder<AppDbContext>()
        .UseInMemoryDatabase(databaseName: "PedidosTestDb")
        .Options;
    return new AppDbContext(options);
  }

  [Fact]
  public async Task AddAsync_AddsPedido()
  {
    var context = GetDbContext();
    var repo = new PedidosRepositoryImpl(context);
    var pedido = new Pedidos();

    await repo.AddAsync(pedido);
    var pedidos = await repo.GetAllAsync();

    Assert.Single(pedidos);
  }
}
