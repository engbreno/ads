using ClientesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientesAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Aqui você pode adicionar configurações adicionais para o modelo, se necessário.
        // Ex: modelBuilder.Entity<Cliente>().ToTable("TB_CLIENTES");
        base.OnModelCreating(modelBuilder);
    }
}
