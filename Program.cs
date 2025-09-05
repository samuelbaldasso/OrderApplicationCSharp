using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Repositório
builder.Services.AddScoped<PedidosRepository, PedidosRepositoryImpl>();

// Serviço de Pedidos
builder.Services.AddScoped<IPedidosService, PedidosServiceImpl>();

// CORS
builder.Services.AddCors(options =>
{
  options.AddPolicy("AllowAngularOrigin",
      builder => builder
          .AllowAnyOrigin()
          .AllowAnyHeader()
          .AllowAnyMethod());
});

// Controllers
builder.Services.AddControllers();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Error");
  app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

// Ative o CORS aqui
app.UseCors("AllowAngularOrigin");

app.MapControllers();

app.Run();