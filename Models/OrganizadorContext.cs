using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace OrganizadorDeTarefas.Models
{
    public class OrganizadorContext : DbContext
    {
        public DbSet<TarefaSimples> Tarefas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ConexaoPadrao");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}