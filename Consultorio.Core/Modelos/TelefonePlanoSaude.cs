namespace Consultorio.Core.Modelos;

public class TelefonePlanoSaude
{
    public long Codigo { get; set; }
    public long CodigoPlano { get; set; }
    public int? DDD { get; set; }
    public int? Telefone { get; set; }
    public string Observacao { get; set; } = string.Empty;
}
