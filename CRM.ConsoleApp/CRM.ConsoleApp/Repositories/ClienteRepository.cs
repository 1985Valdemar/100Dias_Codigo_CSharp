﻿using CRM.ConsoleApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.ConsoleApp.Repositories
{
    public class ClienteRepository
    {

        //****** INICIAR ID EM ZERO
        //****** _id para indicar que ficar nesta classe somente
        private static int _id = 0;

        //****** CRIAR VARIAVEL PARA ARMAZENAR NOME TXT
        private string _nomeArquivo = "listaClientes.txt";


        //****** Construtor para carregar dados do arquivo e inicializar o ID
        public ClienteRepository()
        {
            if (File.Exists(_nomeArquivo))
            {
                InicializarId();
            }
        }

        //****** Inicializa o ID baseado no maior ID presente no arquivo
        //****** Método para inicializar o ID baseado no maior ID presente no arquivo
        private void InicializarId()
        {
            using (StreamReader streamReader = new StreamReader(_nomeArquivo))
            {
                string linha;
                while ((linha = streamReader.ReadLine()) != null)
                {
                    // Dividir a linha em campos
                    string[] dados = linha.Split(";");
                    int id = Convert.ToInt32(dados[0]);
                    // Atualizar o ID para garantir que seja único
                    _id = Math.Max(_id, id);
                }
            }
        }

        //****** Método para criar um novo cliente e salvar no arquivo
        public string Create(Cliente model)
        {
            //****** Incrementa o ID e adiciona ao modelo
            _id++;
            model.Id = _id;

            //****** Salvar o cliente no arquivo de texto
            using (StreamWriter sw = new StreamWriter(_nomeArquivo, append: true))
            {
                sw.WriteLine($"{model.Id};{model.Nome};{model.Sobrenome};{model.Telefone};{model.Cpf}");
            }

            return $"Cliente: {model.Nome} cadastrado com sucesso!";
        }

        //****** Método para obter todos os clientes do arquivo
        public List<Cliente> GetAll()
        {
            List<Cliente> listaCliente = new List<Cliente>();

            //****** Carrega os dados do arquivo de texto
            if (File.Exists(_nomeArquivo))
            {
                using (StreamReader streamReader = new StreamReader(_nomeArquivo))
                {
                    string linha;
                    while ((linha = streamReader.ReadLine()) != null)
                    {
                        // Dividir a linha em campos
                        string[] dados = linha.Split(";");

                        if (dados.Length < 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Linha com dados insuficientes, ignorando...");
                            continue;
                        }

                        Cliente cliente = new Cliente
                        {
                            Id = Convert.ToInt32(dados[0]),
                            Nome = dados[1],
                            Sobrenome = dados[2],
                            Telefone = Convert.ToInt32(dados[3]),
                            Cpf = dados[4]
                        };
                        listaCliente.Add(cliente);
                    }
                }
            }

            return listaCliente;
        }

    }
}
