using ConsoleApp2.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteRepository _clienteRepository;

        public ClienteController()
        {
            _clienteRepository = new ClienteRepository();
            _clienteRepository.CriarTabela(); // Garantir que a tabela será criada
        }

        // Ação principal para listar todos os clientes
        public IActionResult Index()
        {
            var clientes = _clienteRepository.ObterTodos(); // Retorna uma lista de clientes
            return View(clientes);
        }

        // Exibe o formulário de criação
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Processa o envio do formulário de criação
        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _clienteRepository.Create(cliente.Nome, cliente.Sobrenome, cliente.Telefone, cliente.Cpf);
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // Exibe o formulário de edição
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var cliente = _clienteRepository.ObterPorId(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        // Processa o envio do formulário de edição
        [HttpPost]
        public IActionResult Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _clienteRepository.Update(cliente.Id, cliente.Nome, cliente.Sobrenome, cliente.Telefone, cliente.Cpf);
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // Processa a exclusão de um cliente
        [HttpPost]
        public IActionResult Delete(string cpf)
        {
            _clienteRepository.Delete(cpf);
            return RedirectToAction(nameof(Index));
        }
    }
}
