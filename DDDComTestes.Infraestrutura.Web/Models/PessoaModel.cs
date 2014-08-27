using System;
using System.Linq;
using DDDComTestes.Dominio.Entidades.Pessoas;

namespace DDDComTestes.Infraestrutura.Web.Models
{
    public class PessoaModel
    {
        public PessoaModel(Pessoa pessoa)
        {
            if (null == pessoa)
            {
                throw new ArgumentNullException("pessoa");
            }

            ID = pessoa.ID;
            Nome = pessoa.Nome;
            Idade = pessoa.Idade;

            Documento cpf = pessoa.Documentos
                .FirstOrDefault(documento => documento.Tipo == TipoDocumento.CPF);

            if (null != cpf)
            {
                CPF = cpf.Numero;
            }
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
    }
}