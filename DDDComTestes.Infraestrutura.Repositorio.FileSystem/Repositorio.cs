using System.Collections.Generic;
using DDDComTestes.Dominio.Entidades;
using DDDComTestes.Dominio.Entidades.Pessoas;
using DDDComTestes.Dominio.Repositorios;

namespace DDDComTestes.Infraestrutura.Repositorio.FileSystem
{
    public class Repositorio<TEntidade> : IRepositorio<TEntidade> where TEntidade : IEntidade
    {
        public void Salvar(TEntidade entidade)
        {
            //TODO implementar
        }

        public void Excluir(TEntidade entidade)
        {
            //TODO implementar
        }

        public IEnumerable<TEntidade> CarregarTodos()
        {
            //TODO implementar

            return (IEnumerable<TEntidade>)new List<Pessoa>();
        }

        public TEntidade CarregarPorID(int id)
        {
            //TODO implementar

            return default(TEntidade);
        }
    }
}
