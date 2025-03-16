namespace Alura.Adopet.Console.Servicos.Abstracoes;

public interface IApiService<T>
{
    Task CreateAsync(T entity);
    Task<IEnumerable<T>?> ListAsync();
}
