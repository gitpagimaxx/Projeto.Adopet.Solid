using Alura.Adopet.Console.Servicos.Abstracoes;
using System.Text.Json;

namespace Alura.Adopet.Console.Servicos.Arquivos;

public class LeitorDeArquivoJson<T> : ILeitorDeArquivos<T>
{
    private readonly string _caminhoArquivo;

    public LeitorDeArquivoJson(string caminhoArquivo)
    {
        _caminhoArquivo = caminhoArquivo;
    }

    public IEnumerable<T>? RealizaLeitura()
    {
        using Stream stream = new FileStream(_caminhoArquivo, FileMode.Open, FileAccess.Read);
        
        return JsonSerializer.Deserialize<IEnumerable<T>>(stream) ?? Enumerable.Empty<T>();
    }
}