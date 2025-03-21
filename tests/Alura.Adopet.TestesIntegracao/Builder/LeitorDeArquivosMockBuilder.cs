﻿using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Arquivos;
using Moq;

namespace Alura.Adopet.TestesIntegracao.Builder;

internal static class LeitorDeArquivosMockBuilder
{
    public static Mock<PetDoCsv> GetMock(List<Pet> listaDePet)
    {
        var leitorDeArquivo = new Mock<PetDoCsv>(MockBehavior.Default,
            It.IsAny<string>());

        leitorDeArquivo.Setup(_ => _.RealizaLeitura()).Returns(listaDePet);

        return leitorDeArquivo;
    }
}