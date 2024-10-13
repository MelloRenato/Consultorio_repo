using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Consultorio.Api.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Codigo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: true),
                    Bairro = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: true),
                    Cidade = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: true),
                    UF = table.Column<string>(type: "VARCHAR(2)", maxLength: 2, nullable: true),
                    CEP = table.Column<string>(type: "VARCHAR(9)", maxLength: 9, nullable: true),
                    DataNasc = table.Column<DateOnly>(type: "Date", nullable: true),
                    DataCadastro = table.Column<DateOnly>(type: "Date", nullable: false),
                    Observacao = table.Column<string>(type: "MEDIUMTEXT", maxLength: 1024, nullable: true),
                    Empresa = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: true),
                    Referencia = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: true),
                    CPF = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: true),
                    CarteiraPlanoSaude = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: true),
                    CodigoPlanoSaude = table.Column<int>(type: "MEDIUMINT", nullable: true),
                    ResponsavelLegal = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Codigo);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EmailCliente",
                columns: table => new
                {
                    Codigo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CodigoCliente = table.Column<int>(type: "MEDIUMINT", nullable: false),
                    EMail = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: false),
                    Observacao = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailCliente", x => x.Codigo);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PlanosSaude",
                columns: table => new
                {
                    Codigo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    CNPJ = table.Column<string>(type: "VARCHAR(14)", maxLength: 14, nullable: false),
                    Observacao = table.Column<string>(type: "MEDIUMTEXT", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanosSaude", x => x.Codigo);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TelefoneCliente",
                columns: table => new
                {
                    Codigo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CodigoCliente = table.Column<int>(type: "MEDIUMINT", nullable: false),
                    Tipo = table.Column<string>(type: "VARCHAR(15)", maxLength: 15, nullable: false),
                    Telefone = table.Column<string>(type: "VARCHAR(15)", maxLength: 15, nullable: false),
                    Observacao = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelefoneCliente", x => x.Codigo);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TelefonePlanoSaude",
                columns: table => new
                {
                    Codigo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CodigoPlano = table.Column<int>(type: "MEDIUMINT", nullable: false),
                    DDD = table.Column<sbyte>(type: "TINYINT", maxLength: 2, nullable: true),
                    Telefone = table.Column<string>(type: "VARCHAR(15)", maxLength: 15, nullable: false),
                    Observacao = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelefonePlanoSaude", x => x.Codigo);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "EmailCliente");

            migrationBuilder.DropTable(
                name: "PlanosSaude");

            migrationBuilder.DropTable(
                name: "TelefoneCliente");

            migrationBuilder.DropTable(
                name: "TelefonePlanoSaude");
        }
    }
}
