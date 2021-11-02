using Microsoft.EntityFrameworkCore;
using MyTodo.Models;

namespace MyTodo.Data
{
    // Classe de representação do banco de dados em memória
    public class AppDbContext : DbContext
    {
        // Propriedade que representa a tabela do banco de dados
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");
        
    }
}
