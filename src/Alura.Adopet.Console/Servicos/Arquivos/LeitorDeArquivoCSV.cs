using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;

namespace Alura.Adopet.Console.Servicos.Arquivos;

public abstract class LeitorDeArquivoCsv<T> : ILeitorDeArquivos<T>
{
    private string caminhoDoArquivoASerLido;

    public LeitorDeArquivoCsv(string caminhoDoArquivoASerLido)
    {
        this.caminhoDoArquivoASerLido = caminhoDoArquivoASerLido;
    }

    public virtual IEnumerable<T> RealizaLeitura()
    {
        if (string.IsNullOrEmpty(caminhoDoArquivoASerLido))
        {
            throw new ArgumentException("Caminho do arquivo a ser lido não informado!");
        }

        List<T> lista = new();
        using StreamReader sr = new(caminhoDoArquivoASerLido);

        while (!sr.EndOfStream)
        {
            string? linha = sr.ReadLine();
            if (linha is not null)
            {
                var objeto = CriarDaLinhaCsv(linha);
                lista.Add(objeto);
            }
        }
        return lista;
    }

    public abstract T CriarDaLinhaCsv(string linha);
}
