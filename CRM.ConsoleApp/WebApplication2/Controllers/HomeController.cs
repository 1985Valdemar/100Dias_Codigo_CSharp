using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            try
            {
                // Operações com o banco de dados
                var usuarios = _context.Usuarios.ToList();
                return View(usuarios);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao acessar a lista de usuários.");
                return View("Error", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AddUsuario()
        {
            var usuario = new Usuario
            {
                Nome = "João",
                Sobrenome = "Silva",
                CPF = "12345678900",
                Telefone = "987654321"
            };
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
