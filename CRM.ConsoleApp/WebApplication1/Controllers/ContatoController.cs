using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repositories;
using System.Collections.Generic;
using System.Linq;

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
            var contatos = _contatoRepository.ObterTodos().OrderBy(c => c.Id).ToList();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepository.Adicionar(contato);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            ContatoModel contato = _contatoRepository.BuscarPorId(id);
            if (contato == null)
            {
                return NotFound();
            }
            return View(contato);
        }

        [HttpPost]
        public IActionResult Editar(ContatoModel contato)
        {
            if (ModelState.IsValid)
            {
                _contatoRepository.Atualizar(contato);
                return RedirectToAction("Index");
            }
            return View(contato);
        }

        // Exibe a página de confirmação antes de deletar
        public IActionResult Apagar(int id)
        {
            ContatoModel contato = _contatoRepository.BuscarPorId(id);
            if (contato == null)
            {
                return NotFound();
            }
            return View(contato);
        }

        // Confirma e deleta o contato
        [HttpPost]
        public IActionResult ConfirmarApagar(int id)
        {
            _contatoRepository.Apagar(id);
            return RedirectToAction("Index");
        }
    }
}
