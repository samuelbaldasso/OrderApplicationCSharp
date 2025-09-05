using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/pedidos")]
public class PedidosController : ControllerBase
{
  private readonly IPedidosService _repo;

  public PedidosController(IPedidosService repo)
  {
    _repo = repo;
  }

  [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var pedidos = await _repo.GetAllAsync();
        return Ok(pedidos);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Pedidos pedido)
    {
        await _repo.AddAsync(pedido);
        return CreatedAtAction(nameof(GetAll), pedido);
    }
}
