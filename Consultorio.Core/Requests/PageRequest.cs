namespace Consultorio.Core.Request;

public abstract class PageRequest
{
    public int NumeroPaginaPadrao { get; set; } = Configuracao.NumeroPaginaPadrao;
    public int TamanhoPaginaPadrao { get; set; } = Configuracao.TamanhoPaginaPadrao;
}
