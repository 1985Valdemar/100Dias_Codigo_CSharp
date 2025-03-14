﻿using ConsoleApp2.Common;
using ConsoleApp2.Modelos;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2.Repositories
{
    public class ClienteRepository
    {



        private string _connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1234;Database=Pratica1";

        // Método para criar a tabela Clientes, caso não exista
        public void CriarTabela()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string query = @"
                    CREATE TABLE IF NOT EXISTS Clientes (
                        Id SERIAL PRIMARY KEY,
                        Nome VARCHAR(100),
                        Sobrenome VARCHAR(100),
                        Telefone VARCHAR(15),
                        Cpf VARCHAR(11)
                    );";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    MetodosViews.Mensagem("Tabela 'Clientes' criada ou já existe.");
                }
            }
        }

        // Método para criar um cliente no banco
        public int Create(string nome, string sobrenome, string telefone, string cpf)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Clientes (Nome, Sobrenome, Telefone, Cpf) VALUES (@Nome, @Sobrenome, @Telefone, @Cpf) RETURNING Id";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Sobrenome", sobrenome);
                    command.Parameters.AddWithValue("@Telefone", telefone);
                    command.Parameters.AddWithValue("@Cpf", cpf);

                    // Retorna o ID gerado pelo banco de dados
                    return (int)command.ExecuteScalar();
                }
            }
        }

        // Método para obter todos os clientes com paginação
        public List<Cliente> ObterTodos(int pageNumber = 1, int pageSize = 10)
        {
            var clientes = new List<Cliente>();
            int offset = (pageNumber - 1) * pageSize;

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Nome, Sobrenome, Telefone, Cpf FROM Clientes ORDER BY Id LIMIT @PageSize OFFSET @Offset";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PageSize", pageSize);
                    command.Parameters.AddWithValue("@Offset", offset);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clientes.Add(new Cliente
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                Sobrenome = reader.GetString(2),
                                Telefone = reader.GetString(3),
                                Cpf = reader.GetString(4)
                            });
                        }
                    }
                }
            }

            return clientes;
        }

        // Método para buscar clientes por nome ou CPF
        public List<Cliente> Buscar(string termo)
        {
            var clientes = new List<Cliente>();

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Nome, Sobrenome, Telefone, Cpf FROM Clientes WHERE Nome ILIKE @Termo OR Cpf = @Termo";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Termo", "%" + termo + "%");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clientes.Add(new Cliente
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                Sobrenome = reader.GetString(2),
                                Telefone = reader.GetString(3),
                                Cpf = reader.GetString(4)
                            });
                        }
                    }
                }
            }

            return clientes;
        }

        // Método para exibir todos os clientes no console
        public void ExibirClientes(int pageNumber = 1)
        {
            var clientes = ObterTodos(pageNumber);
            if (clientes.Count > 0)
            {
                foreach (var cliente in clientes)
                {
                    Console.WriteLine($"Id: {cliente.Id}, Nome: {cliente.Nome}, Sobrenome: {cliente.Sobrenome}, Telefone: {cliente.Telefone}, CPF: {cliente.Cpf}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum cliente encontrado.");
            }
        }

        // Método para deletar um cliente pelo CPF
        public void Delete(string cpf)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Clientes WHERE Cpf = @Cpf";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Cpf", cpf);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        MetodosViews.Mensagem("Cliente deletado com sucesso.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        MetodosViews.Mensagem("Cliente não encontrado.");
                    }
                }
            }
        }

        // Método para atualizar um cliente
        public void Update(int id, string nome, string sobrenome, string telefone, string cpf)
        {
            // Validações de entrada
            if (!ValidarNome(nome))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                MetodosViews.Mensagem("Nome inválido. Deve conter apenas letras.");
                return;
            }

            if (!ValidarNome(sobrenome))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                MetodosViews.Mensagem("Sobrenome inválido. Deve conter apenas letras.");
                return;
            }

            if (!ValidarTelefone(telefone))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                MetodosViews.Mensagem("Telefone inválido. Deve conter apenas números.");
                return;
            }

            if (!ValidarCpf(cpf))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                MetodosViews.Mensagem("CPF inválido. Deve conter apenas números.");
                return;
            }

            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"
                        UPDATE Clientes 
                        SET Nome = @Nome, 
                            Sobrenome = @Sobrenome, 
                            Telefone = @Telefone, 
                            Cpf = @Cpf 
                        WHERE Id = @Id";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@Sobrenome", sobrenome);
                        command.Parameters.AddWithValue("@Telefone", telefone);
                        command.Parameters.AddWithValue("@Cpf", cpf);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            MetodosViews.Mensagem("Cliente atualizado com sucesso.");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            MetodosViews.Mensagem("Cliente não encontrado.");
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                MetodosViews.Mensagem($"Erro de banco de dados: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                MetodosViews.Mensagem($"Erro inesperado: {ex.Message}");
            }
        }

        // Métodos de validação
        private bool ValidarNome(string nome)
        {
            return nome.All(char.IsLetter);
        }

        private bool ValidarTelefone(string telefone)
        {
            return telefone.All(char.IsDigit);
        }

        private bool ValidarCpf(string cpf)
        {
            return cpf.All(char.IsDigit);
        }

        // Método para obter um cliente pelo CPF
        public Cliente ObterPorCpf(string cpf)
        {
            Cliente cliente = null;

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Nome, Sobrenome, Telefone, Cpf FROM Clientes WHERE Cpf = @Cpf";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Cpf", cpf);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = new Cliente
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                Sobrenome = reader.GetString(2),
                                Telefone = reader.GetString(3),
                                Cpf = reader.GetString(4)
                            };
                        }
                    }
                }
            }

            return cliente;
        }

        public string? ObterPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
