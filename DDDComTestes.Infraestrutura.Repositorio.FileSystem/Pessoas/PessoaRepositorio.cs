using DDDComTestes.Dominio.Entidades.Pessoas;
using DDDComTestes.Dominio.Repositorios.Pessoas;

namespace DDDComTestes.Infraestrutura.Repositorio.FileSystem.Pessoas
{
    public class PessoaRepositorio : Repositorio<Pessoa>, IPessoaRepositorio
    {
        public Pessoa CarregarPorCPF(string cpf)
        {
            //TODO implementar

            return null;
        }
    }
}
