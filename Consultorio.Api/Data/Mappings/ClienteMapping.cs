using Consultorio.Core.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Consultorio.Api.Data.Mappings;

public class ClienteMapping : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Cliente");

        builder.HasKey(x => x.Codigo);
        
        builder.Property(x => x.Nome)
            .IsRequired(true)
            .HasColumnType("VARCHAR")
            .HasMaxLength(150);

        builder.Property(x => x.Endereco)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(150);

        builder.Property(x => x.Bairro)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(100);

        builder.Property(x => x.Cidade)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(100);

        builder.Property(x => x.UF)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(2);

        builder.Property(x => x.CEP)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(9);

        builder.Property(x => x.DataNasc)
            .IsRequired(false)
            .HasColumnType("Date");

        builder.Property(x => x.DataCadastro)
            .IsRequired(true)
            .HasColumnType("Date");

        builder.Property(x => x.Observacao)
            .IsRequired(false)
            .HasColumnType("MEDIUMTEXT")
            .HasMaxLength(1024);

        builder.Property(x => x.Empresa)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(150);

        builder.Property(x => x.Referencia)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(150);

        builder.Property(x => x.CPF)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(11);

        builder.Property(x => x.CarteiraPlanoSaude)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(20);

        builder.Property(x => x.CodigoPlanoSaude)
            .IsRequired(false)
            .HasColumnType("MEDIUMINT");

        builder.Property(x => x.ResponsavelLegal)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(150);
    }
}
