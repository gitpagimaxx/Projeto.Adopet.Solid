using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Servicos.Arquivos
{
    public class PetsDoJson : LeitorDeArquivoJson<Cliente>
    {
        public PetsDoJson(string caminhoArquivo) : base(caminhoArquivo)
        {
        }


    }
}
