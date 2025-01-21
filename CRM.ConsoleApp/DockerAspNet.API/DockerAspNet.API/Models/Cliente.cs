namespace DockerAspNet.API.Models
{
    public class Cliente: BaseModel
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Sobrenome: {Sobrenome}, Telefone: {Telefone}, CPF: {Cpf}";
        }
    }
}
