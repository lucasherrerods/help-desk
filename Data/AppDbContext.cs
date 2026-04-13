using Microsoft.EntityFrameworkCore;
using help_desk.Models;

namespace help_desk.Data
{
  public class AppDbContext : DbContext
  {
    // Construtor
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // Tabela no banco
    public DbSet<Chamado> Chamados { get; set; }
  }
}