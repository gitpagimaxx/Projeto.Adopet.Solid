using Alura.Adopet.Console.Servicos.Arquivos;

namespace Alura.Adopet.Testes.Servicos;

public class LeitorArquivoFactoryTest
{
    [Fact]
    public void QuandoExtensaoCsvDeveRetornarTipoAdequado()
    {
        // arrange
        string caminhoDoArquivo = "lista.csv";

        // act
        var leitor = LeitorDeArquivosFactory.CreateLeitorDePets(caminhoDoArquivo);

        // assert
        Assert.NotNull(leitor);
        Assert.IsType<PetDoCsv>(leitor);
    }

    [Fact]
    public void QuandoExtensaoCsvDeveRetornarClientesDoCsv()
    {
        // arrange
        string caminhoDoArquivo = "lista.csv";

        // act
        var leitor = LeitorDeArquivosFactory.CreateLeitorDeClientes(caminhoDoArquivo);

        // assert
        Assert.NotNull(leitor);
        Assert.IsType<ClientesDoCsv>(leitor);
    }

    [Fact]
    public void QuandoExtensaoJsonDeveRetornarClientesDoJson()
    {
        // arrange
        string caminhoDoArquivo = "lista.json";

        // act
        var leitor = LeitorDeArquivosFactory.CreateLeitorDeClientes(caminhoDoArquivo);

        // assert
        Assert.NotNull(leitor);
        Assert.IsType<ClientesDoJson>(leitor);
    }

    [Fact]
    public void QuandoExtensaoJsonDeveRetornarTipoAdequado()
    {
        // arrange
        string caminhoDoArquivo = "qualquernome.json";

        // act
        var leitor = LeitorDeArquivosFactory.CreateLeitorDePets(caminhoDoArquivo);

        // assert
        Assert.NotNull(leitor);
        Assert.IsType<PetsDoJson>(leitor);
    }
}