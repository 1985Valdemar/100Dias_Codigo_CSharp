using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using LogLevel = WebApplication1.Models.LogLevel;

namespace WebApplication1.Data
{
    public class BancoContext : DbContext
    {
        // CONSTRUTOR DO CONTEXTO DO BANCO DADOS
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        // TABELAS NO BANCO DE DADOS
        public DbSet<ContatoModel> Contato { get; set; }
        public DbSet<LogLevel> LogLevels { get; set; }
        public DbSet<ConnectionStrings> ConnectionStrings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContatoModel>()
                .HasKey(c => c.Id); // Define a chave primária explicitamente, se necessário

            // Configurações adicionais para LogLevel e ConnectionStrings se necessário
        }
    }
}
