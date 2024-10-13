using Consultorio.Core.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Consultorio.Api.Data;

public class AppDbContext(DbContextOptions<AppDbContext> optins) : DbContext(optins)
{

    public DbSet<Cliente> Clientes { get; set; } = null!;
    public DbSet<EmailCliente> EmailsClientes { get; set; } = null!;
    public DbSet<PlanoSaude> PlanosSaude { get; set; } = null!;
    public DbSet<TelefoneCliente> TelefonesClientes { get; set; } = null!;
    public DbSet<TelefonePlanoSaude> TelefonesPlanosSaude { get; set; } = null!;



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
