using System.Text.Json.Serialization;

namespace Consultorio.Core.Responses;

public class PageResponse<TDados> : Response<TDados>
{
    [JsonConstructor]
    public PageResponse(TDados? dados, int totalRegistros, int paginaAtual=1, int tamanhoPagina=Configuracao.TamanhoPaginaPadrao)
                        : base(dados)
    {
        Dados = dados;
        TotalRegstros = totalRegistros;
        PaginaAtual = paginaAtual;
        TamanhoPagina = tamanhoPagina;
        
    }

    public PageResponse(TDados? dados, int codigoStatus = Configuracao.CodigoStatusPadrao, string mensagem = null)
                        : base(dados, codigoStatus, mensagem) 
    { 
        
    }

    public int PaginaAtual { get; set; }
    public int TotalPaginas
        => (int)Math.Ceiling(TotalPaginas / (double)TamanhoPagina);
    public int TamanhoPagina { get; set; } = Configuracao.TamanhoPaginaPadrao;
    public int TotalRegstros { get; set; }
}

