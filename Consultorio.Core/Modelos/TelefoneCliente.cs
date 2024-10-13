namespace Consultorio.Core.Modelos;

public class TelefoneCliente
{
    public long Codigo { get; set; }
    public long CodigoCliente { get; set; }
    public string Tipo { get; set; } = string.Empty;
    public int? Telefone { get; set; }
    public string Observacao { get; set; } = string.Empty;
}
