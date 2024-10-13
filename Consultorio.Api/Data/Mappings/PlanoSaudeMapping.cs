using Consultorio.Core.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Consultorio.Api.Data.Mappings;

public class PlanoSaudeMapping : IEntityTypeConfiguration<PlanoSaude>
{
    public void Configure(EntityTypeBuilder<PlanoSaude> builder)
    {
        builder.ToTable("PlanosSaude");
        
        builder.HasKey(x=>x.Codigo);
        builder.Property(x=>x.Nome)
            .IsRequired(true)
            .HasColumnType("VARCHAR")
            .HasMaxLength(100);
        builder.Property(x => x.CNPJ)
            .HasColumnType("VARCHAR")
            .HasMaxLength(14);
        builder.Property(x => x.Observacao)
            .HasColumnType("MEDIUMTEXT")
            .HasMaxLength(1024);
    }
}
