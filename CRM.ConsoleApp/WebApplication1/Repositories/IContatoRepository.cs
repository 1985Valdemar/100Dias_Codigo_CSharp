using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface IContatoRepository
    {
        ContatoModel Adicionar(ContatoModel contato);
    }
}
