using Consultorio.Core.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Consultorio.Api.Data.Mappings;

public class TelefoneClienteMapping : IEntityTypeConfiguration<TelefoneCliente>
{
    public void Configure(EntityTypeBuilder<TelefoneCliente> builder)
    {
        builder.ToTable("TelefoneCliente");
        builder.HasKey(x => x.Codigo);

        builder.Property(x => x.CodigoCliente)
            .IsRequired(true)
            .HasColumnType("MEDIUMINT");
        builder.Property(x => x.Tipo)
            .IsRequired(true)
            .HasColumnType("VARCHAR")
            .HasMaxLength(15);
        builder.Property(x=>x.Telefone)
            .IsRequired(true)
            .HasColumnType("VARCHAR")
            .HasMaxLength(15);
        builder.Property(x => x.Observacao)
            .HasColumnType("VARCHAR")
            .HasMaxLength(255);
    }


}
