using Npgsql;
using System;

namespace ConsoleApp1.Repositories
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
                    Console.WriteLine("Tabela 'Clientes' criada ou já existe.");
                }
            }
        }

        // Método para criar um cliente no banco
        public void Create(string nome, string sobrenome, string telefone, string cpf)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Clientes (Nome, Sobrenome, Telefone, Cpf) VALUES (@Nome, @Sobrenome, @Telefone, @Cpf)";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    // Parâmetros para evitar SQL Injection
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Sobrenome", sobrenome);
                    command.Parameters.AddWithValue("@Telefone", telefone);
                    command.Parameters.AddWithValue("@Cpf", cpf);

                    // Executa o comando no banco
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
