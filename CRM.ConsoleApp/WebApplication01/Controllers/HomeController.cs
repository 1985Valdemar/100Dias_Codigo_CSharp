using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(); // Se n�o for necess�rio carregar dados aqui, o Index pode continuar vazio
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
