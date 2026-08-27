using ChatSignalRCurso.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatSignalRCurso.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            :base(options)
        {
            
        }

        public DbSet<Mensagem> Mensagens { get; set; }
    }
}
