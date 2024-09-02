using Microsoft.EntityFrameworkCore;

namespace Comandas
{

    //classe representante do banco de dados
    public class AppDbContext : DbContext
    {
        //propriedade q representa a tabela Usuario
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cardapio> Cardapios { get; set; }

        //metodo que configura irformando para o EF que o banco será SQlite
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=comandas.db");
        }
    }

}
