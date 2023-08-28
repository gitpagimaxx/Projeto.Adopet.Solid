﻿using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Servicos.Arquivos;

public class LeitorDeArquivo
{
    private string caminhoDoArquivoASerLido;
    public LeitorDeArquivo(string caminhoDoArquivoASerLido)
    {
        this.caminhoDoArquivoASerLido = caminhoDoArquivoASerLido;
    }

    public virtual List<Pet> RealizaLeitura()
    {
        if (string.IsNullOrEmpty(caminhoDoArquivoASerLido))
        {
            return null;
        }
        List<Pet> listaDePet = new List<Pet>();
        using StreamReader sr = new StreamReader(caminhoDoArquivoASerLido);
        while (!sr.EndOfStream)
        {
            string? linha = sr.ReadLine();
            if (linha is not null)
                listaDePet.Add(linha.ConverteDoTexto());
        }
        return listaDePet;
    }
}
