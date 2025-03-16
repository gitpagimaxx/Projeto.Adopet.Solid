using Alura.Adopet.Console.Servicos.Arquivos;

namespace Alura.Adopet.Testes.Comandos;

public class LeitorDeArquivosFactoryTests
{
    [Fact]
    public void CreatePetFrom_ShouldReturnLeitorDeArquivoJson_WhenJsonFile()
    {
        // Arrange
        var caminhoArquivo = "pets.json";

        // Act
        var result = LeitorDeArquivosFactory.CreatePetFrom(caminhoArquivo);

        // Assert
        Assert.IsType<LeitorDeArquivoJson>(result);
    }

    [Fact]
    public void CreatePetFrom_ShouldReturnLeitorDeArquivoCsv_WhenCsvFile()
    {
        // Arrange
        var caminhoArquivo = "pets.csv";

        // Act
        var result = LeitorDeArquivosFactory.CreatePetFrom(caminhoArquivo);

        // Assert
        Assert.IsType<LeitorDeArquivoCsv>(result);
    }

    [Fact]
    public void CreatePetFrom_ShouldThrowNotSupportedException_WhenUnsupportedFile()
    {
        // Arrange
        var caminhoArquivo = "pets.txt";

        // Act & Assert
        Assert.Throws<NotSupportedException>(() => LeitorDeArquivosFactory.CreatePetFrom(caminhoArquivo));
    }
}
