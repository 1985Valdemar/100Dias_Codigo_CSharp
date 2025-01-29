using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // Garante que o Id seja gerado automaticamente
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = string.Empty;  // Garantir que tenha um valor inicial

        [Required]
        public string Sobrenome { get; set; } = string.Empty;  // Garantir que tenha um valor inicial

        [Required]
        public string CPF { get; set; } = string.Empty;  // Garantir que tenha um valor inicial

        [Required]
        public string Telefone { get; set; } = string.Empty;  // Garantir que tenha um valor inicial
    }
}
