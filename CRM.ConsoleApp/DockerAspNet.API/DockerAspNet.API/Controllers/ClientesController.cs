using DockerAspNet.API.Models;
using DockerAspNet.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DockerAspNet.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController: ControllerBase
    {
        private readonly ClienteRepository _clienteRepository;

        public ClientesController(ClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
            _clienteRepository.CriarTabela(); // Certifique-se de que a tabela foi criada
        }

        [HttpGet]
        public ActionResult<List<Cliente>> GetClientes()
        {
            return _clienteRepository.ObterTodos();
        }

        [HttpGet("{cpf}")]
        public ActionResult<Cliente> GetClientePorCpf(string cpf)
        {
            var cliente = _clienteRepository.ObterPorCpf(cpf);
            if (cliente == null)
            {
                return NotFound();
            }
            return cliente;
        }

        [HttpPost]
        public ActionResult<int> CreateCliente([FromBody] Cliente cliente)
        {
            var id = _clienteRepository.Create(cliente.Nome, cliente.Sobrenome, cliente.Telefone, cliente.Cpf);
            return CreatedAtAction(nameof(GetClientePorCpf), new { cpf = cliente.Cpf }, id);
        }

        [HttpDelete("{cpf}")]
        public IActionResult DeleteCliente(string cpf)
        {
            _clienteRepository.Delete(cpf);
            return NoContent();
        }
    }
}