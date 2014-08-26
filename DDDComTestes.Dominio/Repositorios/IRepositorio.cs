using System.Collections.Generic;
using DDDComTestes.Dominio.Entidades;

namespace DDDComTestes.Dominio.Repositorios
{
    public interface IRepositorio<TEntidade> where TEntidade : IEntidade
    {
        void Salvar(TEntidade entidade);
        void Excluir(TEntidade entidade);
        IEnumerable<TEntidade> CarregarTodos();
        TEntidade CarregarPorID(int id);
    }
}