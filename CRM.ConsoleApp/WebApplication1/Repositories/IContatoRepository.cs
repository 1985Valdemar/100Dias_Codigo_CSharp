using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface IContatoRepository
    {
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato); // Método para editar o contato
        ContatoModel BuscarPorId(int id); // Método para buscar contato pelo ID
        IEnumerable<ContatoModel> ObterTodos();

    }
}
