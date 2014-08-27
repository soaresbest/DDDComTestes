using DDDComTestes.Dominio.Entidades.Pessoas;

namespace DDDComTestes.Dominio.Repositorios.Pessoas
{
    public interface IPessoaRepositorio : IRepositorio<Pessoa>
    {
        Pessoa CarregarPorCPF(string cpf);
    }
}
