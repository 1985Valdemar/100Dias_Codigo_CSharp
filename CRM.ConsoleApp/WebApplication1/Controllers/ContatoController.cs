using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoController(IContatoRepository contatoRepository) 
        {
            _contatoRepository = contatoRepository;
        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Criar()
        {

            return View();
        }
        public IActionResult Editar()
        {

            return View();
        }
        public IActionResult Apagar()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato) 
        {
            _contatoRepository.Adicionar(contato);
            return RedirectToAction("Index");
        }
    }
}
