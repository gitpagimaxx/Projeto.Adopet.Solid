﻿using Alura.Adopet.Console.Atributos;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Results;
using Alura.Adopet.Console.Servicos.Abstracoes;
using FluentResults;

namespace Alura.Adopet.Console.Comandos;

[DocComando(instrucao: "import-clientes", documentacao: "teste")]
public class ImportClientes : IComando
{
    private readonly IApiService<Cliente> service;
    private readonly ILeitorDeArquivos<Cliente> leitor;

    public ImportClientes(IApiService<Cliente> service, ILeitorDeArquivos<Cliente> leitor)
    {
        this.service = service;
        this.leitor = leitor;
    }

    public async Task<Result> ExecutarAsync()
    {
        try
        {
            var clientes = leitor.RealizaLeitura();

            foreach (var cliente in clientes)
            {
                await service.CreateAsync(cliente);
            }

            return Result.Ok().WithSuccess(new SuccessWithClientes(clientes, "Importação realizada com sucesso!"));
        }
        catch (Exception exception)
        {
            return Result.Fail(new Error("Importação falhou!").CausedBy(exception));
        }
    }
}
