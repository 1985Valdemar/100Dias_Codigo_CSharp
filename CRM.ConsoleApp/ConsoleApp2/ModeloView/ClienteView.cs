using ConsoleApp2.Common;
using ConsoleApp2.Repositories;
using System;

namespace CRM.ConsoleApp2.Views
{
    public class ClienteView
    {
        private readonly ClienteRepository _clienteRepository;

        public ClienteView()
        {
            _clienteRepository = new ClienteRepository();
            _clienteRepository.CriarTabela(); // Garante que a tabela será criada
        }

        public void ExibirMenu()
        {
            int opcao;

            do
            {
                MetodosViews.Limpar();
                //****** INSERINDO COR ******
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nBem-vindo ao Cadastro de Clientes!");
                Console.WriteLine("1. Listar Clientes");
                Console.WriteLine("2. Cadastrar Novo Cliente");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    MetodosViews.Mensagem("Opção inválida! Por favor, insira um número.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        ListarClientes();
                        break;
                    case 2:
                        CadastrarCliente();
                        break;
                    case 0:
                        MetodosViews.Mensagem("Saindo...");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        MetodosViews.Mensagem("Opção inválida! Por favor, escolha uma opção válida.");
                        break;
                }
            } while (opcao != 0);
        }

        private void ListarClientes()
        {
            Console.WriteLine("\nLista de Clientes:");
            var clientes = _clienteRepository.ObterTodos(); // Supondo que você tenha um método ObterTodos() no ClienteRepository
            if (clientes.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                MetodosViews.Mensagem("Nenhum cliente cadastrado.");
            }
            else
            {
                foreach (var cliente in clientes)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Nome: {cliente.Nome}, Sobrenome: {cliente.Sobrenome}, Telefone: {cliente.Telefone}, CPF: {cliente.Cpf}");
                }
            }
        }

        private void CadastrarCliente()
        {
            MetodosViews.Limpar();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nCadastro de Novo Cliente");

            Console.Write("Digite o Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o Sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.Write("Digite o Telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine();

            _clienteRepository.Create(nome, sobrenome, telefone, cpf);

            Console.ForegroundColor = ConsoleColor.Green;
            MetodosViews.Mensagem("Cliente cadastrado com sucesso!");
        }

    }
}
