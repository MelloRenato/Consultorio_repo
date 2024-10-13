using Consultorio.Core.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Consultorio.Api.Data.Mappings;

public class TelefonePlanoSaudeMapping : IEntityTypeConfiguration<TelefonePlanoSaude>
{
    public void Configure(EntityTypeBuilder<TelefonePlanoSaude> builder)
    {
        builder.ToTable("TelefonePlanoSaude");
        builder.HasKey(x => x.Codigo);

        builder.Property(x => x.CodigoPlano)
            .IsRequired(true)
            .HasColumnType("MEDIUMINT");
        builder.Property(x => x.DDD)
            .HasColumnType("TINYINT")
            .HasMaxLength(2);
        builder.Property(x => x.Telefone)
            .IsRequired(true)
            .HasColumnType("VARCHAR")
            .HasMaxLength(15);
        builder.Property(x => x.Observacao)
            .HasColumnType("VARCHAR")
            .HasMaxLength(255);
    }
}
