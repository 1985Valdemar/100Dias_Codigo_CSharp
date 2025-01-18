﻿using ConsoleApp2.Common;
using ConsoleApp2.Modelos;
using Npgsql;
using System;
using System.Collections.Generic;

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
        public void Create(string nome, string sobrenome, string telefone, string cpf)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Clientes (Nome, Sobrenome, Telefone, Cpf) VALUES (@Nome, @Sobrenome, @Telefone, @Cpf)";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Sobrenome", sobrenome);
                    command.Parameters.AddWithValue("@Telefone", telefone);
                    command.Parameters.AddWithValue("@Cpf", cpf);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para obter todos os clientes
        public List<Cliente> ObterTodos()
        {
            var clientes = new List<Cliente>();

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT Nome, Sobrenome, Telefone, Cpf FROM Clientes";

                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clientes.Add(new Cliente
                        {
                            Nome = reader.GetString(0),
                            Sobrenome = reader.GetString(1),
                            Telefone = reader.GetString(2),
                            Cpf = reader.GetString(3)
                        });
                    }
                }
            }

            return clientes;
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
        // Método para obter um cliente pelo CPF
        public Cliente ObterPorCpf(string cpf)
        {
            Cliente cliente = null;

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT Nome, Sobrenome, Telefone, Cpf FROM Clientes WHERE Cpf = @Cpf";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Cpf", cpf);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = new Cliente
                            {
                                Nome = reader.GetString(0),
                                Sobrenome = reader.GetString(1),
                                Telefone = reader.GetString(2),
                                Cpf = reader.GetString(3)
                            };
                        }
                    }
                }
            }
            return cliente;
        }
    }
}
