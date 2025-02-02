using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ContatoModel
    {
        [Key] // Indica que esta propriedade é a chave primária
        public int Id { get; set; }

        [Required] // Indica que este campo é obrigatório
        [StringLength(100)] // Limita o tamanho do nome
        public string Nome { get; set; }

        [Required] // Indica que este campo é obrigatório
        [EmailAddress] // Valida se o formato do email está correto
        [StringLength(100)] // Limita o tamanho do email
        public string Email { get; set; }

        [Required] // Indica que este campo é obrigatório
        [StringLength(100)] // Limita o tamanho do nome
        public string Celular { get; set; }

    }
}
