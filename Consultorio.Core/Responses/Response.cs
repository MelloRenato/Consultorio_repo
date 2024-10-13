using System.Text.Json.Serialization;

namespace Consultorio.Core.Responses;
public class Response<TDados>
{
    
    private readonly int _Codigo;

    [JsonConstructor]
    public Response()
        => _Codigo = Configuracao.CodigoStatusPadrao;   

    public Response(TDados dados, int codigo = Configuracao.CodigoStatusPadrao, string? mensagem = null)
    {
        Dados = dados;
        Mensagem = mensagem;
        _Codigo = codigo;
    }
    public TDados? Dados { get; set; }
    public string? Mensagem { get; set; } = string.Empty;
    
    [JsonIgnore]
    public bool Sucesso 
        => _Codigo is >= 200 and <= 299;
}
