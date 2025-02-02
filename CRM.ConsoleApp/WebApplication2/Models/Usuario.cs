using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // Garante que o Id seja gerado automaticamente
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres.")]
        public string Nome { get; set; } = string.Empty;  // Garantir que tenha um valor inicial

        [Required(ErrorMessage = "O sobrenome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O sobrenome não pode exceder 100 caracteres.")]
        public string Sobrenome { get; set; } = string.Empty;  // Garantir que tenha um valor inicial

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [StringLength(14, ErrorMessage = "O CPF deve ter exatamente 14 caracteres.", MinimumLength = 11)]
        public string CPF { get; set; } = string.Empty;  // Garantir que tenha um valor inicial

        [StringLength(15, ErrorMessage = "O telefone não pode exceder 15 caracteres.")]
        public string Telefone { get; set; } = string.Empty;  // Garantir que tenha um valor inicial
    }
}
