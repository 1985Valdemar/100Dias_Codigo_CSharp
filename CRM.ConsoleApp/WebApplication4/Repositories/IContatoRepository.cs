﻿using WebApplication4.Models;

namespace WebApplication4.Repositories
{
    public interface IContatoRepository
    {
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato); // Método para editar o contato
        ContatoModel BuscarPorId(int id); // Método para buscar contato pelo ID
        IEnumerable<ContatoModel> ObterTodos();
        void Apagar(int id); // Método para deletar

    }
}
