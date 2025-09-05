using Moq;

public class PedidosServiceTests
{
  [Fact]
  public async Task GetAllAsync_ReturnsPedidosList()
  {
    // Arrange
    var pedidosList = new List<Pedidos> { new Pedidos() };
    var repoMock = new Mock<PedidosRepository>();
    repoMock.Setup(r => r.GetAllAsync()).ReturnsAsync(pedidosList);
    var service = new PedidosServiceImpl(repoMock.Object);

    // Act
    var result = await service.GetAllAsync();

    // Assert
    Assert.NotNull(result);
    Assert.Single(result);
  }

  [Fact]
  public async Task AddAsync_CallsRepositoryAdd()
  {
    // Arrange
    var repoMock = new Mock<PedidosRepository>();
    var service = new PedidosServiceImpl(repoMock.Object);
    var pedido = new Pedidos();

    // Act
    await service.AddAsync(pedido);

    // Assert
    repoMock.Verify(r => r.AddAsync(pedido), Times.Once);
  }
}
