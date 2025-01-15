﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Sobrenome: {Sobrenome}, Telefone: {Telefone}, CPF: {Cpf}";
        }
    }

}