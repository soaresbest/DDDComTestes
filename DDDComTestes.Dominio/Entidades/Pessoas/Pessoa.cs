using System.Collections.Generic;

namespace DDDComTestes.Dominio.Entidades.Pessoas
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public IEnumerable<Documento> Documentos { get; set; }
        public IEnumerable<Endereco> Enderecos { get; set; }
    }
}
