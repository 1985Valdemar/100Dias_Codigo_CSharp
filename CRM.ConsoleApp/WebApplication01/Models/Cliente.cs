namespace WebApplication1.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }

        public override string ToString()
        {
            return $"{this.Id},{this.Nome},{this.Sobrenome},{this.Telefone},{this.Cpf}";
        }
    }
}
