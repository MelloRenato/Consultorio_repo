namespace Consultorio.Core.Modelos;

public class PlanoSaude
{
    public long Codigo { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string CNPJ { get; set; } = string.Empty;
    public string Observacao { get; set; } = string.Empty;

}
