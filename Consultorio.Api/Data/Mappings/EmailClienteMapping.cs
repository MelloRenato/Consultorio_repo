using Consultorio.Core.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Consultorio.Api.Data.Mappings;

public class EmailClienteMapping : IEntityTypeConfiguration<EmailCliente>
{
    public void Configure(EntityTypeBuilder<EmailCliente> builder)
    {
        builder.ToTable("EmailCliente");

        builder.HasKey(x=>x.Codigo);
        builder.Property(x => x.CodigoCliente)
            .IsRequired(true)
            .HasColumnType("MEDIUMINT");
        builder.Property(x => x.EMail)
            .HasColumnType("VARCHAR")
            .HasMaxLength(250);
        builder.Property(x => x.Observacao)
            .HasColumnType("VARCHAR")
            .HasMaxLength(250);
    }
}
