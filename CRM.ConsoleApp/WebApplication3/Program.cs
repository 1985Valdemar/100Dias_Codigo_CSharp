using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApplication3.Data;
using WebApplication3.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Adicionando o servi�o do banco de dados PostgreSQL
builder.Services.AddDbContext<BancoContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
           .EnableSensitiveDataLogging() // Habilita o registro de dados sens�veis (opcional)
           .LogTo(Console.WriteLine, LogLevel.Information)); // Registra no console

// Adicionando os servi�os do MVC (Controllers e Views)
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IContatoRepository, ContatoRepository>();

var app = builder.Build();

// Configura��o do pipeline de requisi��o HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Configurando a rota padr�o
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

