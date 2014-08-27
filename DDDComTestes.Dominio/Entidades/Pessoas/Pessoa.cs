using System.Collections.Generic;

namespace DDDComTestes.Dominio.Entidades.Pessoas
{
    public class Pessoa : IEntidade
    {
        public Pessoa()
        {
            Documentos = new List<Documento>();
            Enderecos = new List<Endereco>();
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public IList<Documento> Documentos { get; set; }
        public IList<Endereco> Enderecos { get; set; }
    }
}
