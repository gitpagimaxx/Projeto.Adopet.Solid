using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;
using System.Net.Http.Json;

namespace Alura.Adopet.Console.Servicos.Http;

public class ClienteService : IApiService<Cliente>
{
    private readonly HttpClient _client;

    public ClienteService(HttpClient client)
    {
        _client = client;
    }

    public Task CreateAsync(Cliente entity)
    {
        return _client.PostAsJsonAsync("cliente/add", entity);
    }

    public virtual async Task<IEnumerable<Cliente>?> ListAsync()
    {
        HttpResponseMessage response = await _client.GetAsync("cliente/list");
        return await response.Content.ReadFromJsonAsync<IEnumerable<Cliente>>();
    }
}
