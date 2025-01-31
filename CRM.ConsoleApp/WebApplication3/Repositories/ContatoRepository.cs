using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Repositories
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly BancoContext _bancoContext;

        public ContatoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contato.Add(contato);
            _bancoContext.SaveChanges();
            return contato;

        }
    }
}
