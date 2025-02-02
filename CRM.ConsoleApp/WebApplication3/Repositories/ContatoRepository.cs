using WebApplication3.Data;
using WebApplication3.Models;
using Microsoft.EntityFrameworkCore;
using System;

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
            try
            {
                _bancoContext.Contato.Add(contato);
                _bancoContext.SaveChanges();
                return contato;
            }
            catch (DbUpdateException ex)
            {
                // Log error (not shown)
                throw new Exception("Ocorreu um erro ao salvar os dados no banco de dados", ex);
            }
            catch (Exception ex)
            {
                // Log error (not shown)
                throw new Exception("Ocorreu um erro inesperado ao salvar os dados", ex);
            }
        }
    }
}
