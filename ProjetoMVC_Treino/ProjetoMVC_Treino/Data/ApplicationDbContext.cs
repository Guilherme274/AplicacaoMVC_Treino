using Microsoft.EntityFrameworkCore;
using ProjetoMVC_Treino.Models;

namespace ProjetoMVC_Treino.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<EmprestimosModel> Emprestimos { get; set; }
    }
}
