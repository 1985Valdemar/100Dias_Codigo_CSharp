using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Repositories;

namespace WebApplication3.Controllers
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
