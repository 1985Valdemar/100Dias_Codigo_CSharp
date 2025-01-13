using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.ConsoleApp.Modelos
{
    public class Cliente : BaseModel
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Telefone { get; set; }
        public string Cpf { get; set; }

        public override string ToString()
        {
            return $"{this.Id};{this.Nome};{this.Sobrenome};{this.Telefone};{this.Cpf}";
        }
    }
}
