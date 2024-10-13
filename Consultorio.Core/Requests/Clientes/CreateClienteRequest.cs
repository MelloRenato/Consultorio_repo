using System.ComponentModel.DataAnnotations;

namespace Consultorio.Core.Requests.Clientes;

public class CreateClienteRequest
{
    [Required(ErrorMessage = "Obrigatório informar o nome.")]
    public string Nome { get; set; } = string.Empty;
    public string Endereco { get; set; } = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    [MaxLength(2, ErrorMessage = "UF inválida.")]
    public string UF { get; set; } = string.Empty;
    [MaxLength(8, ErrorMessage = "CEP inválido.")]
    public string CEP { get; set; } = string.Empty;
    public DateOnly? DataNasc { get; set; } = null;
    public DateOnly DataCadastro { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    public string Observacao { get; set; } = string.Empty;
    public string Empresa { get; set; } = string.Empty;
    public string Referencia { get; set; } = string.Empty;
    public string CPF { get; set; } = string.Empty;
    public string CarteiraPlanoSaude { get; set; } = string.Empty;
    public long? CodigoPlanoSaude { get; set; }
    public string ResponsavelLegal { get; set; } = string.Empty;
}
