using WebApplication1.Data;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace WebApplication1.Repositories
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
                Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<ContatoModel> entityEntry = _bancoContext.Contato.Add(contato);
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

        public ContatoModel Atualizar(ContatoModel contato)
        {
            try
            {
                var contatoExistente = _bancoContext.Contato.SingleOrDefault(c => c.Id == contato.Id);

                if (contatoExistente == null)
                    throw new Exception("Contato não encontrado");

                contatoExistente.Nome = contato.Nome;
                contatoExistente.Email = contato.Email;
                contatoExistente.Celular = contato.Celular;

                _bancoContext.Contato.Update(contatoExistente);
                _bancoContext.SaveChanges();

                return contatoExistente;
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Erro ao atualizar os dados no banco de dados", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro inesperado ao atualizar os dados", ex);
            }
        }
        public ContatoModel BuscarPorId(int id)
        {
            return _bancoContext.Contato.FirstOrDefault(c => c.Id == id);
        }
        public IEnumerable<ContatoModel> ObterTodos()
        {
            return _bancoContext.Contato.AsEnumerable();
        }
        public void Apagar(int id)
        {
            ContatoModel contato = BuscarPorId(id);
            if (contato != null)
            {
                _bancoContext.Contato.Remove(contato);
                _bancoContext.SaveChanges();
            }
        }




    }
}
