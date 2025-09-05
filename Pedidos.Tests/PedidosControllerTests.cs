using Moq;
using Microsoft.AspNetCore.Mvc;

public class PedidosControllerTests
{
  [Fact]
  public async Task GetAll_ReturnsOkWithPedidos()
  {
    // Arrange
    var pedidosList = new List<Pedidos> { new Pedidos() };
    var serviceMock = new Mock<IPedidosService>();
    serviceMock.Setup(s => s.GetAllAsync()).ReturnsAsync(pedidosList);
    
    var controller = new PedidosController(serviceMock.Object);

    // Act
    var result = await controller.GetAll();

    // Assert
    var okResult = Assert.IsType<OkObjectResult>(result);
    Assert.Equal(pedidosList, okResult.Value);
  }
}