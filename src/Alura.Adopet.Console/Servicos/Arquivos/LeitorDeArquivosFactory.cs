using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;

namespace Alura.Adopet.Console.Servicos.Arquivos;

public static class LeitorDeArquivosFactory
{
    public static ILeitorDeArquivos<Cliente>? CreateLeitorDeClientes(string caminhoArquivo)
    {
        return Path.GetExtension(caminhoArquivo) switch
        {
            ".json" => new ClientesDoJson(caminhoArquivo),
            ".csv" => new ClientesDoCsv(caminhoArquivo),
            _ => throw new NotSupportedException("Formato de arquivo não suportado"),
        };
    }

    public static ILeitorDeArquivos<Pet>? CreateLeitorDePets(string caminhoArquivo)
    {
        return Path.GetExtension(caminhoArquivo) switch
        {
            ".json" => new LeitorDeArquivoJson(caminhoArquivo),
            ".csv" => new PetDoCsv(caminhoArquivo),
            _ => throw new NotSupportedException("Formato de arquivo não suportado"),
        };
    }
}
