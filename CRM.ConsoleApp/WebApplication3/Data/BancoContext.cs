using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class BancoContext : DbContext
    {
        //CONSTRUTOR DO CONTEXTO DO BANCO DADOS
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        //TRAZENDO ENTIDADE MODELO DO CONTATO
        //PROPRIEDADE VAI CRIAR TABELA
        public DbSet<ContatoModel> Contato { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContatoModel>()
                .HasKey(c => c.Id); // Define a chave primária explicitamente, se necessário
        }
    }
}
