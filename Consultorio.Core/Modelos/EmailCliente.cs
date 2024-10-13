namespace Consultorio.Core.Modelos;

public class EmailCliente
{
    public long Codigo { get; set; } 
    public long  CodigoCliente { get; set; }
    public string EMail { get; set; } = string.Empty;
    public string Observacao { get; set; } = string.Empty;
}
