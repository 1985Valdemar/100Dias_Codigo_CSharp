using WebApplication1.Models; // Certifique-se de que o namespace está correto.
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;

namespace WebApplication1.Repositories
{
    public class ClienteRepository
    {
        private readonly string _connectionString;

        public ClienteRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            CriarTabela(); // Garante que a tabela será criada ao instanciar o repositório.
        }

        // Método para criar a tabela Clientes, caso não exista.
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
                    Console.WriteLine("Tabela 'Clientes' criada ou já existe.");
                }
            }
        }

        // Método para criar um cliente no banco.
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

                    return (int)command.ExecuteScalar(); // Retorna o ID gerado pelo banco de dados.
                }
            }
        }

        // Método para obter todos os clientes com paginação.
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

        // Método para buscar clientes por nome ou CPF.
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

        // Método para deletar um cliente pelo CPF.
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
                        Console.WriteLine("Cliente deletado com sucesso.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Cliente não encontrado.");
                    }
                }
            }
        }

        // Método para atualizar um cliente.
        public void Update(int id, string nome, string sobrenome, string telefone, string cpf)
        {
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
                            Console.WriteLine("Cliente atualizado com sucesso.");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Cliente não encontrado.");
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Erro de banco de dados: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }

        // Métodos de validação.
        private bool ValidarNome(string nome) => nome.All(char.IsLetter);

        private bool ValidarTelefone(string telefone) => telefone.All(char.IsDigit);

        private bool ValidarCpf(string cpf) => cpf.All(char.IsDigit);

        // Método para obter um cliente pelo CPF.
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
    }
}
