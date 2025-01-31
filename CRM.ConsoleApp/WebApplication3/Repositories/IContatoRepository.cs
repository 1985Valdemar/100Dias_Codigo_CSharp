using WebApplication3.Models;

namespace WebApplication3.Repositories
{
    public interface IContatoRepository
    {
        ContatoModel Adicionar(ContatoModel contato);
    }
}
