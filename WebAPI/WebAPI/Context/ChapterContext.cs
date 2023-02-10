using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Context
{
    public class ChapterContext : DbContext
    {
        public ChapterContext() { }



        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options) { }



        // vamos utilizar esse método para configurar o banco de dados  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            if (!optionsBuilder.IsConfigured)

            {

                // cada provedor tem sua sintaxe para especificação  

                optionsBuilder.UseSqlServer("Data Source = DESKTOP-6SQ3271\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true");

            }



        }



        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção  

        public DbSet<Livro> Livros { get; set; }
    }
}
