using System.Collections.Generic;
using DDDComTestes.Dominio.Entidades.Pessoas;

namespace DDDComTestes.Dominio.Repositorios.Pessoas
{
    public interface IPessoaRepositorio : IRepositorio<Pessoa>
    {
        IEnumerable<Pessoa> CarregarTodosSemCPF();
    }
}
