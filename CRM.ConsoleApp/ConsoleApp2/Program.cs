using ConsoleApp1.Repositories;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar a tabela, se não existir
            ClienteRepository clienteRepository = new ClienteRepository();
            clienteRepository.CriarTabela();  // Criação da tabela

            Console.WriteLine("Bem-vindo ao Cadastro de Clientes!");

            // Captura dados do cliente
            Console.Write("Digite o Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o Sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.Write("Digite o Telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine();

            // Criação do repositório e cadastro
            clienteRepository.Create(nome, sobrenome, telefone, cpf);

            Console.WriteLine("Cliente cadastrado com sucesso!");
        }
    }
}
